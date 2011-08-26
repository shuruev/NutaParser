namespace NutaParser.Syntactic.Grammar
{
	public class StatementExpression : ParseAny
	{
		public static readonly StatementExpression S = new StatementExpression();

		public StatementExpression()
			: base(
				InvocationExpression.S,
				ObjectCreationExpression.S,
				Assignment.S,
				PostIncrementExpression.S,
				PostDecrementExpression.S,
				PreIncrementExpression.S,
				PreDecrementExpression.S)
		{
		}
	}
}
