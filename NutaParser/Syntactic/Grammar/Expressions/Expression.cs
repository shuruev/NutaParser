namespace NutaParser.Syntactic.Grammar
{
	public class Expression : SyntacticItem
	{
		public static readonly Expression S = new Expression();
		public static readonly Optional O = new Optional(S);

		public override bool Parse(SyntacticState state)
		{
			int innerIndex = state.InnerPosition;
			int outerIndex = state.OuterPosition;

			// non-assignment-expression is required
			if (!NonAssignmentExpression.S.Parse(state))
				return false;

			// if unary-expression has been captured
			// we should try to capture rest parts of assignment
			if (state.CheckEntry(UnaryExpression.S.Key, innerIndex))
			{
				int inner = state.InnerPosition;
				int outer = state.OuterPosition;

				// the rest parts of assigment are assignment-operator
				if (AssignmentOperator.S.Parse(state))
				{
					// and another expression (recursive call here)
					if (S.Parse(state))
					{
					}
					else
					{
						state.Reset(inner, outer);
					}
				}
			}

			state.AddBack(Key, innerIndex, outerIndex);
			return true;
		}
	}
}
