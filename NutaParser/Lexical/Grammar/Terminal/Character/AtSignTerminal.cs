namespace NutaParser.Lexical.Grammar
{
	public class AtSignTerminal : SingleCharacterTerminal
	{
		public static readonly AtSignTerminal S = new AtSignTerminal();

		public AtSignTerminal()
			: base('@')
		{
		}
	}
}
