using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PrimaryExpressionSuffixInvocation : ParseAll
	{
		public static readonly PrimaryExpressionSuffixInvocation S = new PrimaryExpressionSuffixInvocation();

		public PrimaryExpressionSuffixInvocation()
			: base(
				LeftRoundBracketTerminal.S,
				ArgumentList.O,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
