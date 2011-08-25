namespace NutaParser.Syntactic.Grammar
{
	public class NullCoalescingExpression : ParseMany
	{
		public static readonly NullCoalescingExpression S = new NullCoalescingExpression();

		public NullCoalescingExpression()
			: base(
				ConditionalOrExpression.S,
				DoubleQuestionTerminal.S)
		{
		}
	}
}
