﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class UncheckedExpression : ParseAll
	{
		public static readonly UncheckedExpression S = new UncheckedExpression();

		public UncheckedExpression()
			: base(
				UncheckedTerminal.S,
				LeftRoundBracketTerminal.S,
				Expression.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
