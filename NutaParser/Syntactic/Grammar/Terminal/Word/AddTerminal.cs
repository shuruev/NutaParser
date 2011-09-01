namespace NutaParser.Syntactic.Grammar
{
	public class AddTerminal : TextTerminal
	{
		public static readonly AddTerminal S = new AddTerminal();

		public AddTerminal()
			: base("add")
		{
		}
	}
}
