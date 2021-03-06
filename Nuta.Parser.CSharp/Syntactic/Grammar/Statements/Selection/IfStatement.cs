﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class IfStatement : ParseAll
	{
		public static readonly IfStatement S = new IfStatement();

		public IfStatement()
			: base(
				IfTerminal.S,
				LeftRoundBracketTerminal.S,
				BooleanExpression.S,
				RightRoundBracketTerminal.S,
				EmbeddedStatement.S,
				new ParseAny(
					new ParseAll(ElseTerminal.S, EmbeddedStatement.S),
					Empty.S))
		{
		}
	}
}
