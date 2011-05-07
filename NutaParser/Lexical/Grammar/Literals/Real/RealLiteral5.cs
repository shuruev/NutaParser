namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral5 : LexicalItem
	{
		public static readonly RealLiteral5 S = new RealLiteral5();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				PeriodTerminal.S,
				DecimalDigits.S,
				ExponentPart.S,
				RealTypeSuffix.S);
		}
	}
}
