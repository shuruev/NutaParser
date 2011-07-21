namespace NutaParser.Syntactic.Grammar
{
	public class ShortTerminal : TextTerminal
	{
		public static readonly ShortTerminal S = new ShortTerminal();

		public ShortTerminal()
			: base("short")
		{
		}
	}
}
