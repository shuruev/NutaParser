﻿namespace NutaParser.Syntactic.Grammar
{
	public class DoStatement : ParseAll
	{
		public static readonly DoStatement S = new DoStatement();

		public DoStatement()
			: base(
				DoTerminal.S,
				EmbeddedStatement.S,
				WhileTerminal.S,
				LeftRoundBracketTerminal.S,
				BooleanExpression.S,
				RightRoundBracketTerminal.S,
				SemicolonTerminal.S)
		{
		}
	}
}
