namespace NutaParser.Syntactic.Grammar
{
	public class PrivateTerminal : TextTerminal
	{
		public static readonly PrivateTerminal S = new PrivateTerminal();

		public PrivateTerminal()
			: base("private")
		{
		}
	}
}
