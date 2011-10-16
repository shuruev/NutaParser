using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SemicolonTerminal : TextTerminal
	{
		public static readonly SemicolonTerminal S = new SemicolonTerminal();

		public SemicolonTerminal()
			: base(";")
		{
		}
	}
}
