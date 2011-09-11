﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ParameterModifier : ParseAny
	{
		public static readonly ParameterModifier S = new ParameterModifier();
		public static readonly Optional O = new Optional(S);

		public ParameterModifier()
			: base(
				RefTerminal.S,
				OutTerminal.S,
				ThisTerminal.S)
		{
		}
	}
}
