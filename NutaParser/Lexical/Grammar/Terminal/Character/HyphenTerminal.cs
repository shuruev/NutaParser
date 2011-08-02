namespace NutaParser.Lexical.Grammar
{
	public class HyphenTerminal : SingleCharacterTerminal
	{
		public static readonly HyphenTerminal S = new HyphenTerminal();

		public HyphenTerminal()
			: base('-')
		{
		}
	}
}
