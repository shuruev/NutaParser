namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryExpressionSuffixesNotMemberAccess : ParseMany
	{
		public static readonly PrimaryExpressionSuffixesNotMemberAccess S = new PrimaryExpressionSuffixesNotMemberAccess();
		public static readonly Optional O = new Optional(S);

		public PrimaryExpressionSuffixesNotMemberAccess()
			: base(
				new ParseAny(
					PrimaryExpressionSuffixInvocation.S,
					PrimaryExpressionSuffixElementAccess.S,
					PrimaryExpressionSuffixPostIncrement.S,
					PrimaryExpressionSuffixPostDecrement.S))
		{
		}
	}
}
