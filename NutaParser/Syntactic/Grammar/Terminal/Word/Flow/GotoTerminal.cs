namespace NutaParser.Syntactic.Grammar
{
	public class GotoTerminal : TextTerminal
	{
		public static readonly GotoTerminal S = new GotoTerminal();

		public GotoTerminal()
			: base("goto")
		{
		}
	}
}
