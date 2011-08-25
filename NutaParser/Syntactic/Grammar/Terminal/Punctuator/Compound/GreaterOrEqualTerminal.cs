namespace NutaParser.Syntactic.Grammar
{
	public class GreaterOrEqualTerminal : TextTerminal
	{
		public static readonly GreaterOrEqualTerminal S = new GreaterOrEqualTerminal();

		public GreaterOrEqualTerminal()
			: base(">=")
		{
		}
	}
}
