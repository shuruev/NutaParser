namespace NutaParser.Syntactic.Grammar
{
	public class EqualTerminal : TextTerminal
	{
		public static readonly EqualTerminal S = new EqualTerminal();

		public EqualTerminal()
			: base("=")
		{
		}
	}
}
