namespace NutaParser.Syntactic.Grammar
{
	public class NamespaceTerminal : TextTerminal
	{
		public static readonly NamespaceTerminal S = new NamespaceTerminal();

		public NamespaceTerminal()
			: base("namespace")
		{
		}
	}
}
