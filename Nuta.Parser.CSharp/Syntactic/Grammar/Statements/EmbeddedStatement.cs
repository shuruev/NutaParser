﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EmbeddedStatement : SyntacticItem
	{
		public static readonly EmbeddedStatement S = new EmbeddedStatement();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				Block.S,
				EmptyStatement.S,
				ExpressionStatement.S,
				SelectionStatement.S,
				IterationStatement.S,
				JumpStatement.S,
				TryStatement.S,
				CheckedStatement.S,
				UncheckedStatement.S,
				LockStatement.S,
				UsingStatement.S,
				YieldStatement.S);
		}
	}
}
