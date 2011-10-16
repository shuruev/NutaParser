using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class TildeTerminal : SingleCharacterTerminal
	{
		public static readonly TildeTerminal S = new TildeTerminal();

		public TildeTerminal()
			: base('~')
		{
		}
	}
}
