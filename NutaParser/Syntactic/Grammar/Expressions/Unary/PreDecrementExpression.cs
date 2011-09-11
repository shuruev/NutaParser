using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
