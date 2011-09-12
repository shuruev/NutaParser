using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class HorizontalTabTerminal : SingleCharacterTerminal
	{
		public static readonly HorizontalTabTerminal S = new HorizontalTabTerminal();

		public HorizontalTabTerminal()
			: base('\x0009')
		{
		}
	}
}
