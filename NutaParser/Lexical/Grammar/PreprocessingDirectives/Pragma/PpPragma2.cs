namespace NutaParser.Lexical.Grammar
{
	public class PpPragma2 : LexicalItem
	{
		public static readonly PpPragma2 S = new PpPragma2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				SharpTerminal.S,
				PragmaTerminal.S,
				Whitespace.S,
				PragmaBody.S,
				PpNewLine.S);
		}
	}
}
