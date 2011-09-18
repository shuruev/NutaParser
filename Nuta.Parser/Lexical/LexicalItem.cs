using System;

namespace Nuta.Parser.Lexical
{
	/// <summary>
	/// Represents an entity from a lexical grammar.
	/// </summary>
	public abstract class LexicalItem
	{
		#region Properties

		/// <summary>
		/// Gets entity key.
		/// </summary>
		public string Key
		{
			get
			{
				return GetType().Name;
			}
		}

		#endregion

		#region Parsing methods

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public abstract bool Parse(LexicalState state);

		#endregion

		#region Parsing terminal symbols

		/// <summary>
		/// Tries to parse any of specified words.
		/// </summary>
		public bool ParseWord(LexicalState state, bool ignoreCase, params string[] words)
		{
			if (state.IsEndOfData)
				return false;

			foreach (string word in words)
			{
				if (state.Position + word.Length > state.Length)
					continue;

				string captured = state.Get(state.Position, word.Length);
				bool matches = ignoreCase
					? String.Compare(captured, word, StringComparison.OrdinalIgnoreCase) == 0
					: captured == word;

				if (matches)
				{
					state.AddIncrement(Key, word.Length);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Tries to parse any of specified words.
		/// </summary>
		public bool ParseWord(LexicalState state, params string[] words)
		{
			return ParseWord(state, false, words);
		}

		/// <summary>
		/// Tries to parse a single character using specified function.
		/// </summary>
		public bool ParseCharacter(LexicalState state, Func<char, bool> check)
		{
			if (state.IsEndOfData)
				return false;

			if (!check(state.Get(state.Position)))
				return false;

			state.AddIncrement(Key, 1);
			return true;
		}

		#endregion

		#region Parsing other lexical items

		/// <summary>
		/// Tries to parse any of specified lexical items.
		/// </summary>
		public bool ParseAny(LexicalState state, params LexicalItem[] parts)
		{
			int index = state.Position;

			foreach (LexicalItem part in parts)
			{
				if (part.Parse(state))
				{
					state.AddBack(Key, index);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Tries to parse a consequent number of specified lexical items.
		/// </summary>
		public bool ParseAll(LexicalState state, params LexicalItem[] parts)
		{
			int index = state.Position;

			bool parsed = true;
			foreach (LexicalItem part in parts)
			{
				if (!part.Parse(state))
				{
					parsed = false;
					break;
				}
			}

			if (!parsed)
			{
				state.Reset(index);
				return false;
			}

			state.AddBack(Key, index);
			return true;
		}

		/// <summary>
		/// Tries to parse a batch of similar lexical items with specified delimiter.
		/// </summary>
		public bool ParseMany(LexicalState state, LexicalItem part, LexicalItem delimiter)
		{
			if (!part.Parse(state))
				return false;

			while (true)
			{
				int index = state.Position;

				if (delimiter != null)
				{
					if (!delimiter.Parse(state))
						break;
				}

				if (!part.Parse(state))
				{
					state.Reset(index);
					break;
				}
			}

			state.AddAbsolute(Key, state.Position);
			return true;
		}

		/// <summary>
		/// Tries to parse all specified items except some others.
		/// </summary>
		public bool ParseExcept(LexicalState state, LexicalItem main, LexicalItem exception)
		{
			int index = state.Position;

			if (!main.Parse(state))
				return false;

			string parsed = state.Get(main.Key, index);

			LexicalState check = new LexicalState(parsed);
			if (exception.Parse(check))
			{
				if (check.IsEndOfData)
				{
					state.Reset(index);
					return false;
				}
			}

			state.AddBack(Key, index);
			return true;
		}

		#endregion
	}
}
