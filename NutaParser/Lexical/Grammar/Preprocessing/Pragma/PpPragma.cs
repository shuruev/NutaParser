namespace NutaParser.Lexical.Grammar
{
	public class PpPragma : ParseAll
	{
		public static readonly PpPragma S = new PpPragma();

		public PpPragma()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				PragmaTerminal.S,
				Whitespace.S,
				PragmaBody.S,
				PpNewLine.S)
		{
		}
	}
}
