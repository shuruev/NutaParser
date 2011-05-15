namespace NutaParser.Lexical.Grammar
{
	public class PpLine2 : LexicalItem
	{
		public static readonly PpLine2 S = new PpLine2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				LineTerminal.S,
				Whitespace.S,
				LineIndicator.S,
				PpNewLine.S);
		}
	}
}
