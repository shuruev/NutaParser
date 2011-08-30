namespace NutaParser.Syntactic.Grammar
{
	public class TrueTerminal : TextTerminal
	{
		public static readonly TrueTerminal S = new TrueTerminal();

		public TrueTerminal()
			: base("true")
		{
		}
	}
}
