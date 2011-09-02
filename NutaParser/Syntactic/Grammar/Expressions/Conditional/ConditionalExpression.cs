namespace NutaParser.Syntactic.Grammar
{
	public class ConditionalExpression : SyntacticItem
	{
		public static readonly ConditionalExpression S = new ConditionalExpression();

		public override bool Parse(SyntacticState state)
		{
			state.RaiseFlag(StateFlags.IgnoreNullable);

			bool parsed = ParseAll(
				state,
				NullCoalescingExpression.S,
				QuestionTerminal.S,
				Expression.S,
				ColonTerminal.S,
				Expression.S);

			state.LowerFlag(StateFlags.IgnoreNullable);

			if (parsed)
				return true;

			return ParseAny(
				state,
				new ParseAll(
					NullCoalescingExpression.S,
					QuestionTerminal.S,
					Expression.S,
					ColonTerminal.S,
					Expression.S),
				NullCoalescingExpression.S);
		}
	}
}
