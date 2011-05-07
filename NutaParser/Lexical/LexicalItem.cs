using System;

namespace NutaParser.Lexical
{
	public abstract class LexicalItem
	{
		public string Key
		{
			get
			{
				return GetType().Name;
			}
		}

		public abstract bool Parse(LexicalState state);

		public bool ParseWord(LexicalState state, params string[] words)
		{
			if (state.IsEndOfFile)
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

		public bool ParseCharacter(LexicalState state, char character)
		{
			return ParseCharacter(state, c => c == character);
		}

		public bool ParseCharacter(LexicalState state, Func<char, bool> check)
		{
			if (state.IsEndOfFile)
				return false;

			if (!check(state.Data[state.Position]))
				return false;

			state.AddIncrement(Key, 1);
			return true;
		}

		public bool ParseMany(LexicalState state, LexicalItem part)
		{
			return ParseMany(state, part, null);
		}

		public bool ParseMany(LexicalState state, LexicalItem part, LexicalItem delimiter)
		{
			if (state.IsEndOfFile)
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

		public bool ParseAll(LexicalState state, params LexicalItem[] parts)
		{
			if (state.IsEndOfFile)
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

		public bool ParseAny(LexicalState state, params LexicalItem[] parts)
		{
			if (state.IsEndOfFile)
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
	}
}
