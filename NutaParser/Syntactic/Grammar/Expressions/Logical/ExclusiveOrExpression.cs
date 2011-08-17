namespace NutaParser.Syntactic.Grammar
{
	public class ExclusiveOrExpression : ParseAny
	{
		public static readonly ExclusiveOrExpression S = new ExclusiveOrExpression();

		public ExclusiveOrExpression()
			: base(
				AndExpression.S
				/*xxx*/)
		{
		}
	}
}
