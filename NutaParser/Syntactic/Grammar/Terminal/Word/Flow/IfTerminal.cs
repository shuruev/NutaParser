namespace NutaParser.Syntactic.Grammar
{
	public class IfTerminal : TextTerminal
	{
		public static readonly IfTerminal S = new IfTerminal();

		public IfTerminal()
			: base("if")
		{
		}
	}
}
