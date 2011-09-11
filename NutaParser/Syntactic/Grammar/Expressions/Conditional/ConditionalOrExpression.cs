using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ConditionalOrExpression : ParseMany
	{
		public static readonly ConditionalOrExpression S = new ConditionalOrExpression();

		public ConditionalOrExpression()
			: base(
				ConditionalAndExpression.S,
				DoubleBarTerminal.S)
		{
		}
	}
}
