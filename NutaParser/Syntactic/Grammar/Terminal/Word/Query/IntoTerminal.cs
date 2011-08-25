namespace NutaParser.Syntactic.Grammar
{
	public class IntoTerminal : TextTerminal
	{
		public static readonly IntoTerminal S = new IntoTerminal();

		public IntoTerminal()
			: base("into")
		{
		}
	}
}
