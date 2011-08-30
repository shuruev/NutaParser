namespace NutaParser.Syntactic.Grammar
{
	public class FalseTerminal : TextTerminal
	{
		public static readonly FalseTerminal S = new FalseTerminal();

		public FalseTerminal()
			: base("false")
		{
		}
	}
}
