using System;

namespace NutaParser.Lexical
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

		#region Common parsing methods

		/// <summary>
		/// Tries to parse any of specified words.
		/// </summary>
		public bool ParseWord(LexicalState state, params string[] words)
		{
			if (state.IsEndOfData)
				return false;

			foreach (string word in words)
			{
				if (state.Position + word.Length > state.Data.Length)
					continue;

				if (state.Data.Substring(state.Position, word.Length) == word)
				{
					state.AddIncrement(Key, word.Length);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Tries to parse a single specified character.
		/// </summary>
		public bool ParseCharacter(LexicalState state, char character)
		{
			return ParseCharacter(state, c => c == character);
		}

		/// <summary>
		/// Tries to parse a single character using specified function.
		/// </summary>
		public bool ParseCharacter(LexicalState state, Func<char, bool> check)
		{
			if (state.IsEndOfData)
				return false;

			if (!check(state.Data[state.Position]))
				return false;

			state.AddIncrement(Key, 1);
			return true;
		}

		/// <summary>
		/// Tries to parse a batch of similar lexical items.
		/// </summary>
		public bool ParseMany(LexicalState state, LexicalItem part)
		{
			return ParseMany(state, part, null);
		}

		/// <summary>
		/// Tries to parse a batch of similar lexical items with specified delimiter.
		/// </summary>
		public bool ParseMany(LexicalState state, LexicalItem part, LexicalItem delimiter)
		{
			if (state.IsEndOfData)
				return false;

			int index = state.Position;
			while (true)
			{
				if (!part.Parse(state))
					break;

				if (delimiter == null)
					continue;

				if (!delimiter.Parse(state))
					break;
			}

			if (index == state.Position)
				return false;

			state.AddAbsolute(Key, state.Position);
			return true;
		}

		/// <summary>
		/// Tries to parse a consequent number of specified lexical items.
		/// </summary>
		public bool ParseAll(LexicalState state, params LexicalItem[] parts)
		{
			if (state.IsEndOfData)
				return false;

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
		/// Tries to parse any of specified lexical items.
		/// </summary>
		public bool ParseAny(LexicalState state, params LexicalItem[] parts)
		{
			if (state.IsEndOfData)
				return false;

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

		#endregion
	}
}
