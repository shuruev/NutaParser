using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class RightSquareBracketTerminal : TextTerminal
	{
		public static readonly RightSquareBracketTerminal S = new RightSquareBracketTerminal();

		public RightSquareBracketTerminal()
			: base("]")
		{
		}
	}
}
