namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral7 : LexicalItem
	{
		public static readonly RealLiteral7 S = new RealLiteral7();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				PeriodTerminal.S,
				DecimalDigits.S,
				RealTypeSuffix.S);
		}
	}
}
