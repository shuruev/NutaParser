using NutaParser.Lexical;

namespace NutaParser.Syntactic.Grammar
{
	public class ConditionalExpression : SyntacticItem
	{
		public static readonly ConditionalExpression S = new ConditionalExpression();

		public override bool Parse(SyntacticState state)
		{
			int innerIndex = state.InnerPosition;
			int outerIndex = state.OuterPosition;

			// null-coalescing-expression is required
			if (!NullCoalescingExpression.S.Parse(state))
				return false;

			// if captured expression ends with "?"
			LexicalEntry entry = state.GetInner(state.InnerPosition - 1);
			if (state.GetOuter(entry) == "?")
			{
				// check whether "? and :" part goes after
				bool full = ParseAll(
					state,
					QuestionTerminal.S,
					Expression.S,
					ColonTerminal.S,
					Expression.S);

				// if so, everything is OK
				if (full)
				{
					state.AddBack(Key, innerIndex, outerIndex);
					return true;
				}

				// if not, make another attempt to parse conditional expression
				// handling null-coalescing-expression without trailing "?"
				state.Reset(innerIndex, outerIndex);

				// if we could do that, we can return
				if (ParseAll(
						state,
						NullCoalescingExpressionShorten.S,
						QuestionTerminal.S,
						Expression.S,
						ColonTerminal.S,
						Expression.S))
				{
					return true;
				}

				// if not, parse initial null-coalescing-expression once again
				NullCoalescingExpression.S.Parse(state);
			}

			ParseAll(
				state,
				QuestionTerminal.S,
				Expression.S,
				ColonTerminal.S,
				Expression.S);

			state.AddBack(Key, innerIndex, outerIndex);
			return true;
		}
	}
}
