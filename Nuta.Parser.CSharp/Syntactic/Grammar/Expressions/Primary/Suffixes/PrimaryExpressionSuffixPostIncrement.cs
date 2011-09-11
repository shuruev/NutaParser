using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
