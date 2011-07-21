namespace NutaParser.Syntactic.Grammar
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
