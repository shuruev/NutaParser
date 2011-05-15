namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection : ParseAll
	{
		public static readonly PpElseSection S = new PpElseSection();

		public PpElseSection()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				ElseTerminal.S,
				PpNewLine.S,
				ConditionalSection.O)
		{
		}
	}
}
