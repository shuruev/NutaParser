using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class NumberSignTerminal : SingleCharacterTerminal
	{
		public static readonly NumberSignTerminal S = new NumberSignTerminal();

		public NumberSignTerminal()
			: base('#')
		{
		}
	}
}
