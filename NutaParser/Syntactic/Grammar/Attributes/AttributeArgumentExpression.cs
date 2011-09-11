using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AttributeArgumentExpression : ParseAll
	{
		public static readonly AttributeArgumentExpression S = new AttributeArgumentExpression();

		public AttributeArgumentExpression()
			: base(Expression.S)
		{
		}
	}
}
