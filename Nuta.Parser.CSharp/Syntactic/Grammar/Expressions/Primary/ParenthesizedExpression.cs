using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ParenthesizedExpression : ParseAll
	{
		public static readonly ParenthesizedExpression S = new ParenthesizedExpression();

		public ParenthesizedExpression()
			: base(
				LeftRoundBracketTerminal.S,
				Expression.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
