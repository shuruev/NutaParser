using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
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
