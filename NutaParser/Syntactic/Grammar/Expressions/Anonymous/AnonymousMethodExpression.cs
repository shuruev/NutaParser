﻿namespace NutaParser.Syntactic.Grammar
{
	public class AnonymousMethodExpression : ParseAll
	{
		public static readonly AnonymousMethodExpression S = new AnonymousMethodExpression();

		public AnonymousMethodExpression()
			: base(
				DelegateTerminal.S
				/*xxx*/)
		{
		}
	}
}
