namespace NutaParser.Syntactic.Grammar
{
	public class ElseTerminal : TextTerminal
	{
		public static readonly ElseTerminal S = new ElseTerminal();

		public ElseTerminal()
			: base("else")
		{
		}
	}
}
