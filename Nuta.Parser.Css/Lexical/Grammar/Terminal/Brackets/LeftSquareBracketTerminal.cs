using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LeftSquareBracketTerminal : SingleCharacterTerminal
	{
		public static readonly LeftSquareBracketTerminal S = new LeftSquareBracketTerminal();

		public LeftSquareBracketTerminal()
			: base('[')
		{
		}
	}
}
