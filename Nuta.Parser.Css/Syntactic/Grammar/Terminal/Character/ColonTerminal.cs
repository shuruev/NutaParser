using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class ColonTerminal : TextTerminal
	{
		public static readonly ColonTerminal S = new ColonTerminal();
		public static readonly Optional O = new Optional(S);

		public ColonTerminal()
			: base(":")
		{
		}
	}
}
