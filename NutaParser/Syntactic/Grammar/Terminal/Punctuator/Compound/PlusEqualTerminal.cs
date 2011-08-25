namespace NutaParser.Syntactic.Grammar
{
	public class PlusEqualTerminal : TextTerminal
	{
		public static readonly PlusEqualTerminal S = new PlusEqualTerminal();

		public PlusEqualTerminal()
			: base("+=")
		{
		}
	}
}
