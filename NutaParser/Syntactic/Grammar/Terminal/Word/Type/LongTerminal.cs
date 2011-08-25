namespace NutaParser.Syntactic.Grammar
{
	public class LongTerminal : TextTerminal
	{
		public static readonly LongTerminal S = new LongTerminal();

		public LongTerminal()
			: base("long")
		{
		}
	}
}
