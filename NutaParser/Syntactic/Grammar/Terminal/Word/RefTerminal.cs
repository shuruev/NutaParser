namespace NutaParser.Syntactic.Grammar
{
	public class RefTerminal : TextTerminal
	{
		public static readonly RefTerminal S = new RefTerminal();

		public RefTerminal()
			: base("ref")
		{
		}
	}
}
