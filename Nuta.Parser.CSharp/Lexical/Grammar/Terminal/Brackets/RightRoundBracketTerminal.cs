using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class RightRoundBracketTerminal : SingleCharacterTerminal
	{
		public static readonly RightRoundBracketTerminal S = new RightRoundBracketTerminal();

		public RightRoundBracketTerminal()
			: base(')')
		{
		}
	}
}
