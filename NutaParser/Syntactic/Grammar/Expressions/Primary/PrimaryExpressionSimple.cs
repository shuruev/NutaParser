namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryExpressionSimple : ParseAny
	{
		public static readonly PrimaryExpressionSimple S = new PrimaryExpressionSimple();

		public PrimaryExpressionSimple()
			: base(
				PrimaryNoArrayCreationExpressionSimple.S,
				ArrayCreationExpression.S)
		{
		}
	}
}
