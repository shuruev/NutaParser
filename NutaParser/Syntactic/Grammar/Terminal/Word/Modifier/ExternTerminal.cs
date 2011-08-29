namespace NutaParser.Syntactic.Grammar
{
	public class ExternTerminal : TextTerminal
	{
		public static readonly ExternTerminal S = new ExternTerminal();

		public ExternTerminal()
			: base("extern")
		{
		}
	}
}
