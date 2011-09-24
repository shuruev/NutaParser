using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class ColonTerminal : SingleCharacterTerminal
	{
		public static readonly ColonTerminal S = new ColonTerminal();

		public ColonTerminal()
			: base(':')
		{
		}
	}
}
