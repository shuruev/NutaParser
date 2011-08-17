namespace NutaParser.Syntactic.Grammar
{
	public class AndExpression : ParseAny
	{
		public static readonly AndExpression S = new AndExpression();

		public AndExpression()
			: base(
				EqualityExpression.S
				/*xxx*/)
		{
		}
	}
}
