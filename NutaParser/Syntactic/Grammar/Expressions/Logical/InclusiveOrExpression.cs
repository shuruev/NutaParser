using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class InclusiveOrExpression : ParseMany
	{
		public static readonly InclusiveOrExpression S = new InclusiveOrExpression();

		public InclusiveOrExpression()
			: base(
				ExclusiveOrExpression.S,
				BarTerminal.S)
		{
		}
	}
}
