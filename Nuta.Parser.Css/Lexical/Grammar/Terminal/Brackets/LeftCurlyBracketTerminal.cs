using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LeftCurlyBracketTerminal : SingleCharacterTerminal
	{
		public static readonly LeftCurlyBracketTerminal S = new LeftCurlyBracketTerminal();

		public LeftCurlyBracketTerminal()
			: base('{')
		{
		}
	}
}
