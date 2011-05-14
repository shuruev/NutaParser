namespace NutaParser.Lexical.Grammar
{
	public class PpPragma1 : LexicalItem
	{
		public static readonly PpPragma1 S = new PpPragma1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				Whitespace.S,
				PragmaTerminal.S,
				Whitespace.S,
				PragmaBody.S,
				PpNewLine.S);
		}
	}
}
