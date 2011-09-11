using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ConditionalAndExpression : ParseMany
	{
		public static readonly ConditionalAndExpression S = new ConditionalAndExpression();

		public ConditionalAndExpression()
			: base(
				InclusiveOrExpression.S,
				DoubleAmpersandTerminal.S)
		{
		}
	}
}
