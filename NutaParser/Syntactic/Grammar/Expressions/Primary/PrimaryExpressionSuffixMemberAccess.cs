namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryExpressionSuffixMemberAccess : ParseAll
	{
		public static readonly PrimaryExpressionSuffixMemberAccess S = new PrimaryExpressionSuffixMemberAccess();

		public PrimaryExpressionSuffixMemberAccess()
			: base(
				PeriodTerminal.S,
				IdentifierTerminal.S,
				TypeArgumentList.O)
		{
		}
	}
}
