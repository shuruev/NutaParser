namespace NutaParser.Syntactic.Grammar
{
	public class BarEqualTerminal : TextTerminal
	{
		public static readonly BarEqualTerminal S = new BarEqualTerminal();

		public BarEqualTerminal()
			: base("|=")
		{
		}
	}
}
