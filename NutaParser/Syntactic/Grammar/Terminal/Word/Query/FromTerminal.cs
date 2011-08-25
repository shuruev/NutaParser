namespace NutaParser.Syntactic.Grammar
{
	public class FromTerminal : TextTerminal
	{
		public static readonly FromTerminal S = new FromTerminal();

		public FromTerminal()
			: base("from")
		{
		}
	}
}
