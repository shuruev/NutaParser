namespace NutaParser.Syntactic.Grammar
{
	public class NewTerminal : TextTerminal
	{
		public static readonly NewTerminal S = new NewTerminal();

		public NewTerminal()
			: base("new")
		{
		}
	}
}
