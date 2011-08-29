namespace NutaParser.Syntactic.Grammar
{
	public class ContinueTerminal : TextTerminal
	{
		public static readonly ContinueTerminal S = new ContinueTerminal();

		public ContinueTerminal()
			: base("continue")
		{
		}
	}
}
