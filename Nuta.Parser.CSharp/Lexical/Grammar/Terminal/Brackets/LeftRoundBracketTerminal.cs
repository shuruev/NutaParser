using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class LeftRoundBracketTerminal : SingleCharacterTerminal
	{
		public static readonly LeftRoundBracketTerminal S = new LeftRoundBracketTerminal();

		public LeftRoundBracketTerminal()
			: base('(')
		{
		}
	}
}
