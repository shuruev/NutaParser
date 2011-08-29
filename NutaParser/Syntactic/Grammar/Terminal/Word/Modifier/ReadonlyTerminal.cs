namespace NutaParser.Syntactic.Grammar
{
	public class ReadonlyTerminal : TextTerminal
	{
		public static readonly ReadonlyTerminal S = new ReadonlyTerminal();

		public ReadonlyTerminal()
			: base("readonly")
		{
		}
	}
}
