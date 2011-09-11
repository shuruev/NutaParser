using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PrimaryExpressionSuffixesNotPostIncrement : ParseMany
	{
		public static readonly PrimaryExpressionSuffixesNotPostIncrement S = new PrimaryExpressionSuffixesNotPostIncrement();
		public static readonly Optional O = new Optional(S);

		public PrimaryExpressionSuffixesNotPostIncrement()
			: base(
				new ParseAny(
					PrimaryExpressionSuffixMemberAccess.S,
					PrimaryExpressionSuffixInvocation.S,
					PrimaryExpressionSuffixElementAccess.S,
					PrimaryExpressionSuffixPostDecrement.S))
		{
		}
	}
}
