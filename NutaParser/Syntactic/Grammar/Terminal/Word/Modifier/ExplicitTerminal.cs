namespace NutaParser.Syntactic.Grammar
{
	public class ExplicitTerminal : TextTerminal
	{
		public static readonly ExplicitTerminal S = new ExplicitTerminal();

		public ExplicitTerminal()
			: base("explicit")
		{
		}
	}
}
