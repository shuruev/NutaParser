namespace NutaParser.Lexical.Grammar
{
	public class PpPragma4 : LexicalItem
	{
		public static readonly PpPragma4 S = new PpPragma4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				PragmaTerminal.S,
				Whitespace.S,
				PragmaBody.S,
				PpNewLine.S);
		}
	}
}
