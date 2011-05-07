namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral9 : LexicalItem
	{
		public static readonly RealLiteral9 S = new RealLiteral9();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				ExponentPart.S,
				RealTypeSuffix.S);
		}
	}
}
