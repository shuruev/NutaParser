using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StatementExpression : ParseAny
	{
		public static readonly StatementExpression S = new StatementExpression();

		public StatementExpression()
			: base(
				Assignment.S,
				InvocationExpression.S,
				ObjectCreationExpression.S,
				PostIncrementExpression.S,
				PostDecrementExpression.S,
				PreIncrementExpression.S,
				PreDecrementExpression.S)
		{
		}
	}
}
