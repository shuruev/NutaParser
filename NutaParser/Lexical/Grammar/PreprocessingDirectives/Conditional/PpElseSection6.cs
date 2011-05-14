namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection6 : LexicalItem
	{
		public static readonly PpElseSection6 S = new PpElseSection6();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				ElseTerminal.S,
				PpNewLine.S);
		}
	}
}
