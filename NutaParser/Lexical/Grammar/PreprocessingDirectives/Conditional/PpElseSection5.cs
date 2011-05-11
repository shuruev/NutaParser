namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection5 : LexicalItem
	{
		public static readonly PpElseSection5 S = new PpElseSection5();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				SharpTerminal.S,
				Whitespace.S,
				ElseTerminal.S,
				PpNewLine.S);
		}
	}
}
