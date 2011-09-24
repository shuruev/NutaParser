using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class CommaTerminal : TextTerminal
	{
		public static readonly CommaTerminal S = new CommaTerminal();

		public CommaTerminal()
			: base(",")
		{
		}
	}
}
