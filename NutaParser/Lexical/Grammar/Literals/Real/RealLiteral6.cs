namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral6 : LexicalItem
	{
		public static readonly RealLiteral6 S = new RealLiteral6();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				PeriodTerminal.S,
				DecimalDigits.S,
				ExponentPart.S);
		}
	}
}
