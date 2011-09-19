using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
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
