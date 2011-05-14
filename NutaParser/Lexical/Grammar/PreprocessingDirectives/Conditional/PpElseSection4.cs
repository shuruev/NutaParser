namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection4 : LexicalItem
	{
		public static readonly PpElseSection4 S = new PpElseSection4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				ElseTerminal.S,
				PpNewLine.S,
				ConditionalSection.S);
		}
	}
}
