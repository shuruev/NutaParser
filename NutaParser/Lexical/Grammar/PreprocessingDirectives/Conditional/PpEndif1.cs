namespace NutaParser.Lexical.Grammar
{
	public class PpEndif1 : LexicalItem
	{
		public static readonly PpEndif1 S = new PpEndif1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				Whitespace.S,
				EndifTerminal.S,
				PpNewLine.S);
		}
	}
}
