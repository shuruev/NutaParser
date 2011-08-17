namespace NutaParser.Syntactic.Grammar
{
	public class ConditionalOrExpression : ParseAny
	{
		public static readonly ConditionalOrExpression S = new ConditionalOrExpression();

		public ConditionalOrExpression()
			: base(
				ConditionalAndExpression.S
				/*xxx*/)
		{
		}
	}
}
