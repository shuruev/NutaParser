namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral1 : LexicalItem
	{
		public static readonly RealLiteral1 S = new RealLiteral1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				PeriodTerminal.S,
				DecimalDigits.S,
				ExponentPart.S,
				RealTypeSuffix.S);
		}
	}
}
