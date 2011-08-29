namespace NutaParser.Syntactic.Grammar
{
	public class DoTerminal : TextTerminal
	{
		public static readonly DoTerminal S = new DoTerminal();

		public DoTerminal()
			: base("do")
		{
		}
	}
}
