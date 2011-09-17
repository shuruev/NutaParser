using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class ApostropheTerminal : SingleCharacterTerminal
	{
		public static readonly ApostropheTerminal S = new ApostropheTerminal();

		public ApostropheTerminal()
			: base('\'')
		{
		}
	}
}
