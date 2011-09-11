using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PrimaryExpressionSuffixesNotInvocation : ParseMany
	{
		public static readonly PrimaryExpressionSuffixesNotInvocation S = new PrimaryExpressionSuffixesNotInvocation();
		public static readonly Optional O = new Optional(S);

		public PrimaryExpressionSuffixesNotInvocation()
			: base(
				new ParseAny(
					PrimaryExpressionSuffixMemberAccess.S,
					PrimaryExpressionSuffixElementAccess.S,
					PrimaryExpressionSuffixPostIncrement.S,
					PrimaryExpressionSuffixPostDecrement.S))
		{
		}
	}
}
