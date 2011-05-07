namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalIntegerLiteral : LexicalItem
	{
		public static readonly HexadecimalIntegerLiteral S = new HexadecimalIntegerLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				HexadecimalIntegerLiteral1.S,
				HexadecimalIntegerLiteral2.S);
		}
	}
}
