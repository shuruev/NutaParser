namespace NutaParser.Lexical.Grammar
{
	public class PpPragma3 : LexicalItem
	{
		public static readonly PpPragma3 S = new PpPragma3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				Whitespace.S,
				PragmaTerminal.S,
				Whitespace.S,
				PragmaBody.S,
				PpNewLine.S);
		}
	}
}
