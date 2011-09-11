using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class CommaTerminal : SingleCharacterTerminal
	{
		public static readonly CommaTerminal S = new CommaTerminal();

		public CommaTerminal()
			: base(',')
		{
		}
	}
}
