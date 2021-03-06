﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ForStatement : ParseAll
	{
		public static readonly ForStatement S = new ForStatement();

		public ForStatement()
			: base(
				ForTerminal.S,
				LeftRoundBracketTerminal.S,
				ForInitializer.O,
				SemicolonTerminal.S,
				ForCondition.O,
				SemicolonTerminal.S,
				ForIterator.O,
				RightRoundBracketTerminal.S,
				EmbeddedStatement.S)
		{
		}
	}
}
