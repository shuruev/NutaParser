using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class ColonTerminal : TextTerminal
	{
		public static readonly ColonTerminal S = new ColonTerminal();

		public ColonTerminal()
			: base(":")
		{
		}
	}
}
