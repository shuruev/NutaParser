namespace NutaParser.Lexical.Grammar
{
	public class PpLine3 : LexicalItem
	{
		public static readonly PpLine3 S = new PpLine3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				Whitespace.S,
				LineTerminal.S,
				Whitespace.S,
				LineIndicator.S,
				PpNewLine.S);
		}
	}
}
