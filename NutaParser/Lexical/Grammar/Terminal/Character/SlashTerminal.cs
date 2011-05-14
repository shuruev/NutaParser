namespace NutaParser.Lexical.Grammar
{
	public class SlashTerminal : SingleCharacterTerminal
	{
		public static readonly SlashTerminal S = new SlashTerminal();

		public SlashTerminal()
			: base('/')
		{
		}
	}
}
