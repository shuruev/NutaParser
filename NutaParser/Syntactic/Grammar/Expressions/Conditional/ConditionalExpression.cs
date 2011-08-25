namespace NutaParser.Syntactic.Grammar
{
	public class ConditionalExpression : ParseAny
	{
		public static readonly ConditionalExpression S = new ConditionalExpression();

		public ConditionalExpression()
			: base(
				new ParseAll(
					NullCoalescingExpression.S,
					QuestionTerminal.S,
					Expression.S,
					ColonTerminal.S,
					Expression.S),
				NullCoalescingExpression.S)
		{
		}
	}
}
