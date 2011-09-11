﻿using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection : ParseAll
	{
		public static readonly PpElseSection S = new PpElseSection();
		public static readonly Optional O = new Optional(S);

		public PpElseSection()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				ElseTerminal.S,
				PpNewLine.S,
				ConditionalSection.O)
		{
		}
	}
}
