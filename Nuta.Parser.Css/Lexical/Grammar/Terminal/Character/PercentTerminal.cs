using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class PercentTerminal : SingleCharacterTerminal
	{
		public static readonly PercentTerminal S = new PercentTerminal();

		public PercentTerminal()
			: base('%')
		{
		}
	}
}
