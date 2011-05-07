namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral10 : LexicalItem
	{
		public static readonly RealLiteral10 S = new RealLiteral10();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				ExponentPart.S);
		}
	}
}
