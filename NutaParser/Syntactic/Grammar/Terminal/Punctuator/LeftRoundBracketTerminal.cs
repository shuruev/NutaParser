using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class LeftRoundBracketTerminal : TextTerminal
	{
		public static readonly LeftRoundBracketTerminal S = new LeftRoundBracketTerminal();

		public LeftRoundBracketTerminal()
			: base("(")
		{
		}
	}
}
