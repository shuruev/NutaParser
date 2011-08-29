namespace NutaParser.Syntactic.Grammar
{
	public class AssemblyTerminal : TextTerminal
	{
		public static readonly AssemblyTerminal S = new AssemblyTerminal();

		public AssemblyTerminal()
			: base("assembly")
		{
		}
	}
}
