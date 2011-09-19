using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
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
