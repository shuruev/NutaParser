﻿namespace NutaParser.Syntactic.Grammar
{
	public class ArrayType : SyntacticItem
	{
		public static readonly ArrayType S = new ArrayType();

		public override bool Parse(SyntacticState state)
		{
			return ParseAll(
				state,
				TypePart.S,
				QuestionTerminal.O,
				RankSpecifiers.S);
		}
	}
}
