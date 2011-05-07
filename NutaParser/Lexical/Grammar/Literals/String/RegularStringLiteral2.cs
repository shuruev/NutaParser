namespace NutaParser.Lexical.Grammar
{
	public class RegularStringLiteral2 : LexicalItem
	{
		public static readonly RegularStringLiteral2 S = new RegularStringLiteral2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				QuoteTerminal.S,
				QuoteTerminal.S);
		}
	}
}
