namespace NutaParser.Syntactic.Grammar
{
	public class PostIncrementExpression : ParseAll
	{
		public static readonly PostIncrementExpression S = new PostIncrementExpression();

		public PostIncrementExpression()
			: base(
				PrimaryExpressionSimple.S,
				new ParseMany(
					new ParseAll(
						PrimaryExpressionSuffixesNotPostIncrement.O,
						PrimaryExpressionSuffixPostIncrement.S)))
		{
		}
	}
}
