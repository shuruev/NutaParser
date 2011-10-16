﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class LeftCurlyBracketTerminal : TextTerminal
	{
		public static readonly LeftCurlyBracketTerminal S = new LeftCurlyBracketTerminal();

		public LeftCurlyBracketTerminal()
			: base("{")
		{
		}
	}
}
