namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection2 : LexicalItem
	{
		public static readonly PpElseSection2 S = new PpElseSection2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				ElseTerminal.S,
				PpNewLine.S,
				ConditionalSection.S);
		}
	}
}
