namespace NutaParser.Syntactic.Grammar
{
	public class ThisTerminal : TextTerminal
	{
		public static readonly ThisTerminal S = new ThisTerminal();

		public ThisTerminal()
			: base("this")
		{
		}
	}
}
