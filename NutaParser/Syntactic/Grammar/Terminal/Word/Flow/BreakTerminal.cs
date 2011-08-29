namespace NutaParser.Syntactic.Grammar
{
	public class BreakTerminal : TextTerminal
	{
		public static readonly BreakTerminal S = new BreakTerminal();

		public BreakTerminal()
			: base("break")
		{
		}
	}
}
