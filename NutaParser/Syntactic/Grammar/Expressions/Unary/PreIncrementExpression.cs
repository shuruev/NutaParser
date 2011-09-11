using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class PreIncrementExpression : ParseAll
	{
		public static readonly PreIncrementExpression S = new PreIncrementExpression();

		public PreIncrementExpression()
			: base(
				DoublePlusTerminal.S,
				UnaryExpression.S)
		{
		}
	}
}
