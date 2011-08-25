namespace NutaParser.Syntactic.Grammar
{
	public class ByTerminal : TextTerminal
	{
		public static readonly ByTerminal S = new ByTerminal();

		public ByTerminal()
			: base("by")
		{
		}
	}
}
