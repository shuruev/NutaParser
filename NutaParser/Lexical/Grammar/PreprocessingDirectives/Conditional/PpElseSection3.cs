namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection3 : LexicalItem
	{
		public static readonly PpElseSection3 S = new PpElseSection3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SharpTerminal.S,
				Whitespace.S,
				ElseTerminal.S,
				PpNewLine.S,
				ConditionalSection.S);
		}
	}
}
