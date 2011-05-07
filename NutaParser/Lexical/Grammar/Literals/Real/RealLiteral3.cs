namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral3 : LexicalItem
	{
		public static readonly RealLiteral3 S = new RealLiteral3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				PeriodTerminal.S,
				DecimalDigits.S,
				RealTypeSuffix.S);
		}
	}
}
