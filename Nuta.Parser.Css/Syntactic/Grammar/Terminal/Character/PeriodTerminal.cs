using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class PeriodTerminal : TextTerminal
	{
		public static readonly PeriodTerminal S = new PeriodTerminal();

		public PeriodTerminal()
			: base(".")
		{
		}
	}
}
