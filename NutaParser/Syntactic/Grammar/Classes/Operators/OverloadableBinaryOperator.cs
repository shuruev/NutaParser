namespace NutaParser.Syntactic.Grammar
{
	public class OverloadableBinaryOperator : ParseAny
	{
		public static readonly OverloadableBinaryOperator S = new OverloadableBinaryOperator();

		public OverloadableBinaryOperator()
			: base(
				LeftShiftTerminal.S,
				RightShiftTerminal.S,
				DoubleEqualTerminal.S,
				NotEqualTerminal.S,
				GreaterOrEqualTerminal.S,
				LessOrEqualTerminal.S,
				LeftAngleBracketTerminal.S,
				RightAngleBracketTerminal.S,
				PlusTerminal.S,
				MinusTerminal.S,
				AsteriskTerminal.S,
				SlashTerminal.S,
				PercentTerminal.S,
				AmpersandTerminal.S,
				BarTerminal.S,
				CaretTerminal.S)
		{
		}
	}
}
