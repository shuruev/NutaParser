namespace NutaParser.Syntactic.Grammar
{
	public class PlusTerminal : TextTerminal
	{
		public static readonly PlusTerminal S = new PlusTerminal();

		public PlusTerminal()
			: base("+")
		{
		}
	}
}
