namespace NutaParser.Lexical.Grammar
{
	public class DecimalIntegerLiteral : LexicalItem
	{
		public static readonly DecimalIntegerLiteral S = new DecimalIntegerLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				DecimalIntegerLiteral1.S,
				DecimalDigits.S);
		}
	}
}
