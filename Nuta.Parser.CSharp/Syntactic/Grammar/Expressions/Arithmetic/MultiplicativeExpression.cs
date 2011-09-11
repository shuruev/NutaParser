using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MultiplicativeExpression : ParseMany
	{
		public static readonly MultiplicativeExpression S = new MultiplicativeExpression();

		public MultiplicativeExpression()
			: base(
				UnaryExpression.S,
				new ParseAny(
					AsteriskTerminal.S,
					SlashTerminal.S,
					PercentTerminal.S))
		{
		}
	}
}
