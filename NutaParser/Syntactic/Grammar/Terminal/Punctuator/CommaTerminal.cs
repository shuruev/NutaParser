namespace NutaParser.Syntactic.Grammar
{
	public class CommaTerminal : TextTerminal
	{
		public static readonly CommaTerminal S = new CommaTerminal();

		public CommaTerminal()
			: base(",")
		{
		}
	}
}
