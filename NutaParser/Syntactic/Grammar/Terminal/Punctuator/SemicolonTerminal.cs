namespace NutaParser.Syntactic.Grammar
{
	public class SemicolonTerminal : TextTerminal
	{
		public static readonly SemicolonTerminal S = new SemicolonTerminal();

		public SemicolonTerminal()
			: base(";")
		{
		}
	}
}
