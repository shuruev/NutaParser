using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class RelationalExpressionPart : SyntacticItem
	{
		public static readonly RelationalExpressionPart S = new RelationalExpressionPart();

		public override bool Parse(SyntacticState state)
		{
			// check whether we need to ignore nullable types
			int flag = state.GetFlag<int>(StateFlags.IgnoreNullableAfterPosition);
			if (flag > 0 && state.InnerPosition >= flag)
			{
				// perform parsing ignoring nullable types
				state.RaiseFlag(StateFlags.IgnoreNullable);

				bool parsed = ParseAny(
					state,
					new ParseAll(LeftAngleBracketTerminal.S, ShiftExpression.S),
					new ParseAll(RightAngleBracketTerminal.S, ShiftExpression.S),
					new ParseAll(LessOrEqualTerminal.S, ShiftExpression.S),
					new ParseAll(GreaterOrEqualTerminal.S, ShiftExpression.S),
					new ParseAll(IsTerminal.S, Type.S),
					new ParseAll(AsTerminal.S, Type.S));

				state.LowerFlag(StateFlags.IgnoreNullable);
				return parsed;
			}

			// perform usual parsing
			return ParseAny(
				state,
				new ParseAll(LeftAngleBracketTerminal.S, ShiftExpression.S),
				new ParseAll(RightAngleBracketTerminal.S, ShiftExpression.S),
				new ParseAll(LessOrEqualTerminal.S, ShiftExpression.S),
				new ParseAll(GreaterOrEqualTerminal.S, ShiftExpression.S),
				new ParseAll(IsTerminal.S, Type.S),
				new ParseAll(AsTerminal.S, Type.S));
		}
	}
}
