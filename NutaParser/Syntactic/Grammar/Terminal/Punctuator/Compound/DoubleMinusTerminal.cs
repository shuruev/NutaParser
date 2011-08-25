namespace NutaParser.Syntactic.Grammar
{
	public class DoubleMinusTerminal : TextTerminal
	{
		public static readonly DoubleMinusTerminal S = new DoubleMinusTerminal();

		public DoubleMinusTerminal()
			: base("--")
		{
		}
	}
}
