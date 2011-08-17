namespace NutaParser.Syntactic.Grammar
{
	public class ConditionalAndExpression : ParseAny
	{
		public static readonly ConditionalAndExpression S = new ConditionalAndExpression();

		public ConditionalAndExpression()
			: base(
				InclusiveOrExpression.S
				/*xxx*/)
		{
		}
	}
}
