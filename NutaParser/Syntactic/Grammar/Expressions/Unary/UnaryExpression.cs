﻿namespace NutaParser.Syntactic.Grammar
{
	public class UnaryExpression : SyntacticItem
	{
		public static readonly UnaryExpression S = new UnaryExpression();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				PrimaryExpression.S,
				PreIncrementExpression.S,
				PreDecrementExpression.S,
				new ParseAll(PlusTerminal.S, S),
				new ParseAll(MinusTerminal.S, S),
				new ParseAll(ExclamationTerminal.S, S),
				new ParseAll(TildeTerminal.S, S),
				CastExpression.S);
		}
	}
}
