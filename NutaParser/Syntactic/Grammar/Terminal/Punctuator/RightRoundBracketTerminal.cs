using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class RightRoundBracketTerminal : TextTerminal
	{
		public static readonly RightRoundBracketTerminal S = new RightRoundBracketTerminal();

		public RightRoundBracketTerminal()
			: base(")")
		{
		}
	}
}
