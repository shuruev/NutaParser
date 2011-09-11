using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
