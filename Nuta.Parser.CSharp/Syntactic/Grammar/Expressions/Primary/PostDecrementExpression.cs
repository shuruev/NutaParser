﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PostDecrementExpression : ParseAll
	{
		public static readonly PostDecrementExpression S = new PostDecrementExpression();

		public PostDecrementExpression()
			: base(
				PrimaryExpressionSimple.S,
				new ParseMany(
					new ParseAll(
						PrimaryExpressionSuffixesNotPostDecrement.O,
						PrimaryExpressionSuffixPostDecrement.S)))
		{
		}
	}
}
