using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class RightAngleBracketTerminal : SingleCharacterTerminal
	{
		public static readonly RightAngleBracketTerminal S = new RightAngleBracketTerminal();

		public RightAngleBracketTerminal()
			: base('>')
		{
		}
	}
}
