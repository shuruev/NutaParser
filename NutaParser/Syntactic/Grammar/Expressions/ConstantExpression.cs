using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ConstantExpression : ParseAll
	{
		public static readonly ConstantExpression S = new ConstantExpression();

		public ConstantExpression()
			: base(Expression.S)
		{
		}
	}
}
