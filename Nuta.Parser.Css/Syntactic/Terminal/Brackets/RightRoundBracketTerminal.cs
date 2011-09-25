using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
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
