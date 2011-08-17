namespace NutaParser.Syntactic.Grammar
{
	public class InclusiveOrExpression : ParseAny
	{
		public static readonly InclusiveOrExpression S = new InclusiveOrExpression();

		public InclusiveOrExpression()
			: base(
				ExclusiveOrExpression.S
				/*xxx*/)
		{
		}
	}
}
