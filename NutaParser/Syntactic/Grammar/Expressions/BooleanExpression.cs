using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class BooleanExpression : ParseAll
	{
		public static readonly BooleanExpression S = new BooleanExpression();

		public BooleanExpression()
			: base(Expression.S)
		{
		}
	}
}
