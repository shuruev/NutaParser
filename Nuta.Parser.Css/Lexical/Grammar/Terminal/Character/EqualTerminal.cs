using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class EqualTerminal : SingleCharacterTerminal
	{
		public static readonly EqualTerminal S = new EqualTerminal();

		public EqualTerminal()
			: base('=')
		{
		}
	}
}
