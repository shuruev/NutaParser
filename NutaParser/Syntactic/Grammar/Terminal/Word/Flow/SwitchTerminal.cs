namespace NutaParser.Syntactic.Grammar
{
	public class SwitchTerminal : TextTerminal
	{
		public static readonly SwitchTerminal S = new SwitchTerminal();

		public SwitchTerminal()
			: base("switch")
		{
		}
	}
}
