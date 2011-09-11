using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryExpressionSuffixPostIncrement : ParseAll
	{
		public static readonly PrimaryExpressionSuffixPostIncrement S = new PrimaryExpressionSuffixPostIncrement();

		public PrimaryExpressionSuffixPostIncrement()
			: base(DoublePlusTerminal.S)
		{
		}
	}
}
