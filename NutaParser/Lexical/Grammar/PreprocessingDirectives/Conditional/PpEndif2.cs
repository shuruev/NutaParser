namespace NutaParser.Lexical.Grammar
{
	public class PpEndif2 : LexicalItem
	{
		public static readonly PpEndif2 S = new PpEndif2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				EndifTerminal.S,
				PpNewLine.S);
		}
	}
}
