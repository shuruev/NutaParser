﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ExternTerminal : TextTerminal
	{
		public static readonly ExternTerminal S = new ExternTerminal();
		public static readonly Optional O = new Optional(S);

		public ExternTerminal()
			: base("extern")
		{
		}
	}
}
