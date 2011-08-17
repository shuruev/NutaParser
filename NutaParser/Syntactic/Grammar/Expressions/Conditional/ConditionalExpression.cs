namespace NutaParser.Syntactic.Grammar
{
	public class ConditionalExpression : ParseAny
	{
		public static readonly ConditionalExpression S = new ConditionalExpression();

		public ConditionalExpression()
			: base(
				NullCoalescingExpression.S
				/*xxx*/)
		{
		}
	}
}
