namespace NutaParser.Syntactic.Grammar
{
	public class OutTerminal : TextTerminal
	{
		public static readonly OutTerminal S = new OutTerminal();

		public OutTerminal()
			: base("out")
		{
		}
	}
}
