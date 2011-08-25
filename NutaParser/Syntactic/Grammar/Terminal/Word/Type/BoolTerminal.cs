namespace NutaParser.Syntactic.Grammar
{
	public class BoolTerminal : TextTerminal
	{
		public static readonly BoolTerminal S = new BoolTerminal();

		public BoolTerminal()
			: base("bool")
		{
		}
	}
}
