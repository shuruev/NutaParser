namespace NutaParser.Syntactic.Grammar
{
	public class PercentTerminal : TextTerminal
	{
		public static readonly PercentTerminal S = new PercentTerminal();

		public PercentTerminal()
			: base("%")
		{
		}
	}
}
