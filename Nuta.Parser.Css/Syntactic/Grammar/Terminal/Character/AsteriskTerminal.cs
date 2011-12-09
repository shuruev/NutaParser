using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class AsteriskTerminal : TextTerminal
	{
		public static readonly AsteriskTerminal S = new AsteriskTerminal();

		public AsteriskTerminal()
			: base("*")
		{
		}
	}
}
