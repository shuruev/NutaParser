namespace NutaParser.Lexical.Grammar
{
	public class PpLine1 : LexicalItem
	{
		public static readonly PpLine1 S = new PpLine1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				SharpTerminal.S,
				Whitespace.S,
				LineTerminal.S,
				Whitespace.S,
				LineIndicator.S,
				PpNewLine.S);
		}
	}
}
