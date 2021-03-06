﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PpExpression : ParseAll
	{
		public static readonly PpExpression S = new PpExpression();

		public PpExpression()
			: base(
				Whitespace.O,
				PpOrExpression.S,
				Whitespace.O)
		{
		}
	}
}
