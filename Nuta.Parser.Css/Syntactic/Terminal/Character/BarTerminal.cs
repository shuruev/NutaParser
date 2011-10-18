using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class BarTerminal : TextTerminal
	{
		public static readonly BarTerminal S = new BarTerminal();

		public BarTerminal()
			: base("|")
		{
		}
	}
}
