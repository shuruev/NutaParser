namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryExpressionSuffixes : ParseMany
	{
		public static readonly PrimaryExpressionSuffixes S = new PrimaryExpressionSuffixes();
		public static readonly Optional O = new Optional(S);

		public PrimaryExpressionSuffixes()
			: base(
				new ParseAny(
					PrimaryExpressionSuffixMemberAccess.S,
					PrimaryExpressionSuffixInvocation.S,
					PrimaryExpressionSuffixElementAccess.S,
					PrimaryExpressionSuffixPostIncrement.S,
					PrimaryExpressionSuffixPostDecrement.S))
		{
		}
	}
}
