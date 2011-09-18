using System;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public abstract class LetterOther : LexicalItem
	{
		private readonly LexicalItem[] m_items;

		protected LetterOther(char letter)
		{
			char lower = Char.ToLowerInvariant(letter);
			char upper = Char.ToUpperInvariant(letter);

			string lowerHex = ((int)lower).ToString("x");
			string upperHex = ((int)upper).ToString("x");

			m_items = new LexicalItem[]
			{
				new ParseCharacter(c => c == lower || c == upper),
				new ParseAll(
					BackslashTerminal.S,
					new ParseCharacter(c => c == lower || c == upper)),
				new ParseAll(
					BackslashTerminal.S,
					ZeroDigit.O,
					ZeroDigit.O,
					ZeroDigit.O,
					ZeroDigit.O,
					new ParseWord(true, new[] { lowerHex, upperHex }),
					UnicodeWhitespace.O)
			};
		}

		public override bool Parse(LexicalState state)
		{
			return ParseAny(state, m_items);
		}
	}
}
