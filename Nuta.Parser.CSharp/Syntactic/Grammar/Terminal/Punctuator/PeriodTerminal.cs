using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
