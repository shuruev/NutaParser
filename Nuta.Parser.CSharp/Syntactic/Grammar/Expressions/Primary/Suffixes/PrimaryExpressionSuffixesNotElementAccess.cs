﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PrimaryExpressionSuffixesNotElementAccess : ParseMany
	{
		public static readonly PrimaryExpressionSuffixesNotElementAccess S = new PrimaryExpressionSuffixesNotElementAccess();
		public static readonly Optional O = new Optional(S);

		public PrimaryExpressionSuffixesNotElementAccess()
			: base(
				new ParseAny(
					PrimaryExpressionSuffixMemberAccess.S,
					PrimaryExpressionSuffixInvocation.S,
					PrimaryExpressionSuffixPostIncrement.S,
					PrimaryExpressionSuffixPostDecrement.S))
		{
		}
	}
}
