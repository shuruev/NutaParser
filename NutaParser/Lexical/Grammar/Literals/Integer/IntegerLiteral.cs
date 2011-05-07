namespace NutaParser.Lexical.Grammar
{
	public class IntegerLiteral : LexicalItem
	{
		public static readonly IntegerLiteral S = new IntegerLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				HexadecimalIntegerLiteral.S,
				DecimalIntegerLiteral.S);
		}
	}
}
