using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class SlashTerminal : SingleCharacterTerminal
	{
		public static readonly SlashTerminal S = new SlashTerminal();

		public SlashTerminal()
			: base('/')
		{
		}
	}
}
