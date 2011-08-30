namespace NutaParser.Syntactic.Grammar
{
	public class ImplicitTerminal : TextTerminal
	{
		public static readonly ImplicitTerminal S = new ImplicitTerminal();

		public ImplicitTerminal()
			: base("implicit")
		{
		}
	}
}
