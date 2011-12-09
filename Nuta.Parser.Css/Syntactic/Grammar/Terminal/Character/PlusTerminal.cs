using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class PlusTerminal : TextTerminal
	{
		public static readonly PlusTerminal S = new PlusTerminal();

		public PlusTerminal()
			: base("+")
		{
		}
	}
}
