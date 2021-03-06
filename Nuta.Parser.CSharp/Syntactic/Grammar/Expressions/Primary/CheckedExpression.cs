﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class CheckedExpression : ParseAll
	{
		public static readonly CheckedExpression S = new CheckedExpression();

		public CheckedExpression()
			: base(
				CheckedTerminal.S,
				LeftRoundBracketTerminal.S,
				Expression.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
