namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral2 : LexicalItem
	{
		public static readonly RealLiteral2 S = new RealLiteral2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				PeriodTerminal.S,
				DecimalDigits.S,
				ExponentPart.S);
		}
	}
}
