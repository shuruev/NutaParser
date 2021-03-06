﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PpIfSection : ParseAll
	{
		public static readonly PpIfSection S = new PpIfSection();

		public PpIfSection()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				IfTerminal.S,
				Whitespace.S,
				PpExpression.S,
				PpNewLine.S,
				ConditionalSection.O)
		{
		}
	}
}
