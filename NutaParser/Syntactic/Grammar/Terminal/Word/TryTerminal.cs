namespace NutaParser.Syntactic.Grammar
{
	public class TryTerminal : TextTerminal
	{
		public static readonly TryTerminal S = new TryTerminal();

		public TryTerminal()
			: base("try")
		{
		}
	}
}
