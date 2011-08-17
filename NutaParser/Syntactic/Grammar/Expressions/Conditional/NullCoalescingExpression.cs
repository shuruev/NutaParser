namespace NutaParser.Syntactic.Grammar
{
	public class NullCoalescingExpression : ParseAny
	{
		public static readonly NullCoalescingExpression S = new NullCoalescingExpression();

		public NullCoalescingExpression()
			: base(
				ConditionalOrExpression.S
				/*xxx*/)
		{
		}
	}
}
