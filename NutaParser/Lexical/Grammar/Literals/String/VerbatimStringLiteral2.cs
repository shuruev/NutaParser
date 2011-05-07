namespace NutaParser.Lexical.Grammar
{
	public class VerbatimStringLiteral2 : LexicalItem
	{
		public static readonly VerbatimStringLiteral2 S = new VerbatimStringLiteral2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				AtTerminal.S,
				QuoteTerminal.S,
				QuoteTerminal.S);
		}
	}
}
