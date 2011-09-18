using System;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public abstract class LetterHex : LexicalItem
	{
		private readonly LexicalItem[] m_items;

		protected LetterHex(char letter)
		{
			char lower = Char.ToLowerInvariant(letter);
			char upper = Char.ToUpperInvariant(letter);

			string lowerHex = ((int)lower).ToString("x");
			string upperHex = ((int)upper).ToString("x");

			m_items = new LexicalItem[]
			{
				new SingleCharacterTerminal(lower, upper),
				new ParseAll(
					BackslashTerminal.S,
					ZeroDigit.O,
					ZeroDigit.O,
					ZeroDigit.O,
					ZeroDigit.O,
					new SingleWordTerminal(true, lowerHex, upperHex),
					UnicodeWhitespace.O)
			};
		}

		public override bool Parse(LexicalState state)
		{
			return ParseAny(state, m_items);
		}
	}
}
