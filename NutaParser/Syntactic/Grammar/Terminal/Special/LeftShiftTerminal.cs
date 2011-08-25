namespace NutaParser.Syntactic.Grammar
{
	public class LeftShiftTerminal : TextTerminal
	{
		public static readonly LeftShiftTerminal S = new LeftShiftTerminal();

		public LeftShiftTerminal()
			: base("<<")
		{
		}
	}
}
