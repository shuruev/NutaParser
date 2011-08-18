namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryExpressionSuffixPostDecrement : ParseAll
	{
		public static readonly PrimaryExpressionSuffixPostDecrement S = new PrimaryExpressionSuffixPostDecrement();

		public PrimaryExpressionSuffixPostDecrement()
			: base(DoubleMinusTerminal.S)
		{
		}
	}
}
