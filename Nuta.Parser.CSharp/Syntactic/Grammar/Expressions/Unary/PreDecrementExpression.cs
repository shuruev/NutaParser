using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PreDecrementExpression : ParseAll
	{
		public static readonly PreDecrementExpression S = new PreDecrementExpression();

		public PreDecrementExpression()
			: base(
				DoubleMinusTerminal.S,
				UnaryExpression.S)
		{
		}
	}
}
