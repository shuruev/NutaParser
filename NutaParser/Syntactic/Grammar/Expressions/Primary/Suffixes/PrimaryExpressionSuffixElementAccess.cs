namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryExpressionSuffixElementAccess : ParseAll
	{
		public static readonly PrimaryExpressionSuffixElementAccess S = new PrimaryExpressionSuffixElementAccess();

		public PrimaryExpressionSuffixElementAccess()
			: base(
				LeftSquareBracketTerminal.S,
				ArgumentList.S,
				RightSquareBracketTerminal.S)
		{
		}
	}
}
