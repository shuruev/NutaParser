namespace NutaParser.Syntactic.Grammar
{
	public class SealedTerminal : TextTerminal
	{
		public static readonly SealedTerminal S = new SealedTerminal();

		public SealedTerminal()
			: base("sealed")
		{
		}
	}
}
