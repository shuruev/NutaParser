namespace NutaParser.Syntactic.Grammar
{
	public class LetTerminal : TextTerminal
	{
		public static readonly LetTerminal S = new LetTerminal();

		public LetTerminal()
			: base("let")
		{
		}
	}
}
