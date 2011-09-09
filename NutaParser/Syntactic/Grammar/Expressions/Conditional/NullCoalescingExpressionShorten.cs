using NutaParser.Lexical;

namespace NutaParser.Syntactic.Grammar
{
	public class NullCoalescingExpressionShorten : SyntacticItem
	{
		public static readonly NullCoalescingExpressionShorten S = new NullCoalescingExpressionShorten();

		public override bool Parse(SyntacticState state)
		{
			// this is a special case when we are trying to
			// catch null-coalescing-expression without trailing "?"
			int innerIndex = state.InnerPosition;
			int outerIndex = state.OuterPosition;

			// ensure that usual null-coalescing-expression can be parsed
			if (!NullCoalescingExpression.S.Parse(state))
				return false;

			// we should not do anything if captured expression
			// doesn't end with a "?"
			LexicalEntry entry = state.GetInner(state.InnerPosition - 1);
			if (state.GetOuter(entry) != "?")
				return true;

			// get a position of the last type entry
			int lastTypeIndex = -1;
			for (int i = innerIndex; i <= state.InnerPosition; i++)
			{
				if (state.CheckEntry(Type.S.Key, i))
					lastTypeIndex = i;
			}

			// reset parsing and make another attempt
			// ignoring nullable types after specified index
			state.Reset(innerIndex, outerIndex);
			state.SetFlag(StateFlags.IgnoreNullableAfterPosition, lastTypeIndex - 1);

			bool parsed = ParseMany(
				state,
				ConditionalOrExpression.S,
				DoubleQuestionTerminal.S);

			state.ClearFlag(StateFlags.IgnoreNullableAfterPosition);
			return parsed;
		}
	}
}
