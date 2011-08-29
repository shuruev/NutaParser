namespace NutaParser.Syntactic.Grammar
{
	public class MethodTerminal : TextTerminal
	{
		public static readonly MethodTerminal S = new MethodTerminal();

		public MethodTerminal()
			: base("method")
		{
		}
	}
}
