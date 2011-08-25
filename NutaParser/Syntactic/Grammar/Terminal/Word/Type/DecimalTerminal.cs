namespace NutaParser.Syntactic.Grammar
{
	public class DecimalTerminal : TextTerminal
	{
		public static readonly DecimalTerminal S = new DecimalTerminal();

		public DecimalTerminal()
			: base("decimal")
		{
		}
	}
}
