namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral8 : LexicalItem
	{
		public static readonly RealLiteral8 S = new RealLiteral8();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				PeriodTerminal.S,
				DecimalDigits.S);
		}
	}
}
