namespace NutaParser.Lexical.Grammar
{
	public class PpEndif3 : LexicalItem
	{
		public static readonly PpEndif3 S = new PpEndif3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				Whitespace.S,
				EndifTerminal.S,
				PpNewLine.S);
		}
	}
}
