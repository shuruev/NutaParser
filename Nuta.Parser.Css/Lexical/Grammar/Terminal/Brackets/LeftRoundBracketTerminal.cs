using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
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
