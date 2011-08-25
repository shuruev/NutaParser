namespace NutaParser.Syntactic.Grammar
{
	public class LessOrEqualTerminal : TextTerminal
	{
		public static readonly LessOrEqualTerminal S = new LessOrEqualTerminal();

		public LessOrEqualTerminal()
			: base("<=")
		{
		}
	}
}
