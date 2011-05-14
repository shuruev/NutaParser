using System;
using System.Globalization;
using System.Linq;

namespace NutaParser.Lexical.Grammar
{
	public class UnicodeEscapeSequence : ParseAny
	{
		public static readonly UnicodeEscapeSequence S = new UnicodeEscapeSequence();

		public UnicodeEscapeSequence()
			: base(
				new ParseAll(
					new SingleCharacterTerminal('\\'),
					new SingleCharacterTerminal('U'),
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S),
				new ParseAll(
					new SingleCharacterTerminal('\\'),
					new SingleCharacterTerminal('u'),
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S))
		{
		}

		public bool ParseCharacterCategory(LexicalState state, string key, params UnicodeCategory[] categories)
		{
			int index = state.Position;

			if (!Parse(state))
				return false;

			string sequence = state.Get(Key, index);
			char c = (char)Convert.ToInt32(sequence.Substring(2), 16);

			if (!categories.Contains(Char.GetUnicodeCategory(c)))
			{
				state.Reset(index);
				return false;
			}

			state.AddBack(key, index);
			return true;
		}
	}
}
