namespace NutaParser.Lexical.Grammar
{
	public class LineFeedTerminal : SingleCharacterTerminal
	{
		public static readonly LineFeedTerminal S = new LineFeedTerminal();

		public LineFeedTerminal()
			: base('\x000A')
		{
		}
	}
}
