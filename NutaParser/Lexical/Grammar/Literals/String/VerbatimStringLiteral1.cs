namespace NutaParser.Lexical.Grammar
{
	public class VerbatimStringLiteral1 : LexicalItem
	{
		public static readonly VerbatimStringLiteral1 S = new VerbatimStringLiteral1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				AtSignTerminal.S,
				QuoteTerminal.S,
				VerbatimStringLiteralCharacters.S,
				QuoteTerminal.S);
		}
	}
}
