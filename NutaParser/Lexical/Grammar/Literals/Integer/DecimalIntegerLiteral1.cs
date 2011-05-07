namespace NutaParser.Lexical.Grammar
{
	public class DecimalIntegerLiteral1 : LexicalItem
	{
		public static readonly DecimalIntegerLiteral1 S = new DecimalIntegerLiteral1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				IntegerTypeSuffix.S);
		}
	}
}
