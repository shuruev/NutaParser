namespace NutaParser.Lexical.Grammar
{
	public class PpLine4 : LexicalItem
	{
		public static readonly PpLine4 S = new PpLine4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SharpTerminal.S,
				LineTerminal.S,
				Whitespace.S,
				LineIndicator.S,
				PpNewLine.S);
		}
	}
}
