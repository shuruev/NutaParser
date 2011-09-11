using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
