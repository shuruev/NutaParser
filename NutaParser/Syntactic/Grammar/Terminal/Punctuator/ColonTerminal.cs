namespace NutaParser.Syntactic.Grammar
{
	public class ColonTerminal : TextTerminal
	{
		public static readonly ColonTerminal S = new ColonTerminal();

		public ColonTerminal()
			: base(":")
		{
		}
	}
}
