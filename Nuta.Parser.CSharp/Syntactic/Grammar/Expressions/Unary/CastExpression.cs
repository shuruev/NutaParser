using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class CastExpression : ParseAll
	{
		public static readonly CastExpression S = new CastExpression();

		public CastExpression()
			: base(
				LeftRoundBracketTerminal.S,
				Type.S,
				RightRoundBracketTerminal.S,
				UnaryExpression.S)
		{
		}
	}
}
