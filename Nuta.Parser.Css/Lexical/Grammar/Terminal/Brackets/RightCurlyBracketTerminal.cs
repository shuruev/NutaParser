using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class RightCurlyBracketTerminal : SingleCharacterTerminal
	{
		public static readonly RightCurlyBracketTerminal S = new RightCurlyBracketTerminal();

		public RightCurlyBracketTerminal()
			: base('}')
		{
		}
	}
}
