using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
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
