using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
