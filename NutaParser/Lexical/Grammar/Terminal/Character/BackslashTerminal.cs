using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class BackslashTerminal : SingleCharacterTerminal
	{
		public static readonly BackslashTerminal S = new BackslashTerminal();

		public BackslashTerminal()
			: base('\\')
		{
		}
	}
}
