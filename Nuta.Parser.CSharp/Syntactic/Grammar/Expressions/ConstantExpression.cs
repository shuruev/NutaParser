using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
