namespace NutaParser.Syntactic.Grammar
{
	public class DoubleBarTerminal : TextTerminal
	{
		public static readonly DoubleBarTerminal S = new DoubleBarTerminal();

		public DoubleBarTerminal()
			: base("||")
		{
		}
	}
}
