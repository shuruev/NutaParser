using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class SemicolonTerminal : SingleCharacterTerminal
	{
		public static readonly SemicolonTerminal S = new SemicolonTerminal();

		public SemicolonTerminal()
			: base(';')
		{
		}
	}
}
