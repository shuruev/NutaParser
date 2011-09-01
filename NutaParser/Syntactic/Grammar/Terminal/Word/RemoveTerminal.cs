namespace NutaParser.Syntactic.Grammar
{
	public class RemoveTerminal : TextTerminal
	{
		public static readonly RemoveTerminal S = new RemoveTerminal();

		public RemoveTerminal()
			: base("remove")
		{
		}
	}
}
