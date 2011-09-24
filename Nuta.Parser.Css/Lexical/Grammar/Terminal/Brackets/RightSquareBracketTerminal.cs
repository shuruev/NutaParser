using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class RightSquareBracketTerminal : SingleCharacterTerminal
	{
		public static readonly RightSquareBracketTerminal S = new RightSquareBracketTerminal();

		public RightSquareBracketTerminal()
			: base(']')
		{
		}
	}
}
