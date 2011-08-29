namespace NutaParser.Syntactic.Grammar
{
	public class ConstTerminal : TextTerminal
	{
		public static readonly ConstTerminal S = new ConstTerminal();

		public ConstTerminal()
			: base("const")
		{
		}
	}
}
