﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class IsTerminal : TextTerminal
	{
		public static readonly IsTerminal S = new IsTerminal();

		public IsTerminal()
			: base("is")
		{
		}
	}
}
