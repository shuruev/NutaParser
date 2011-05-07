namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral11 : LexicalItem
	{
		public static readonly RealLiteral11 S = new RealLiteral11();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				RealTypeSuffix.S);
		}
	}
}
