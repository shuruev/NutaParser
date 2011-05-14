namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection7 : LexicalItem
	{
		public static readonly PpElseSection7 S = new PpElseSection7();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				Whitespace.S,
				ElseTerminal.S,
				PpNewLine.S);
		}
	}
}
