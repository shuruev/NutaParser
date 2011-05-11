namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection1 : LexicalItem
	{
		public static readonly PpElseSection1 S = new PpElseSection1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				SharpTerminal.S,
				Whitespace.S,
				ElseTerminal.S,
				PpNewLine.S,
				ConditionalSection.S);
		}
	}
}
