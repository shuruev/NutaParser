namespace NutaParser.Syntactic.Grammar
{
	public class UsingTerminal : TextTerminal
	{
		public static readonly UsingTerminal S = new UsingTerminal();

		public UsingTerminal()
			: base("using")
		{
		}
	}
}
