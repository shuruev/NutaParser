namespace NutaParser.Lexical.Grammar
{
	public class RegularStringLiteral1 : LexicalItem
	{
		public static readonly RegularStringLiteral1 S = new RegularStringLiteral1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				QuoteTerminal.S,
				RegularStringLiteralCharacters.S,
				QuoteTerminal.S);
		}
	}
}
