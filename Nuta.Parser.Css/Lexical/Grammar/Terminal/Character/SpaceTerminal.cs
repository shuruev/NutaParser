using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class SpaceTerminal : SingleCharacterTerminal
	{
		public static readonly SpaceTerminal S = new SpaceTerminal();

		public SpaceTerminal()
			: base(' ')
		{
		}
	}
}
