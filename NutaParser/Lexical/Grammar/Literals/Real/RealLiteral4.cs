namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral4 : LexicalItem
	{
		public static readonly RealLiteral4 S = new RealLiteral4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				PeriodTerminal.S,
				DecimalDigits.S);
		}
	}
}
