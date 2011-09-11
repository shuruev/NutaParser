using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PrimaryExpressionSuffixesNotPostDecrement : ParseMany
	{
		public static readonly PrimaryExpressionSuffixesNotPostDecrement S = new PrimaryExpressionSuffixesNotPostDecrement();
		public static readonly Optional O = new Optional(S);

		public PrimaryExpressionSuffixesNotPostDecrement()
			: base(
				new ParseAny(
					PrimaryExpressionSuffixMemberAccess.S,
					PrimaryExpressionSuffixInvocation.S,
					PrimaryExpressionSuffixElementAccess.S,
					PrimaryExpressionSuffixPostIncrement.S))
		{
		}
	}
}
