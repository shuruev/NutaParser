namespace NutaParser.Syntactic.Grammar
{
	public class AsteriskEqualTerminal : TextTerminal
	{
		public static readonly AsteriskEqualTerminal S = new AsteriskEqualTerminal();

		public AsteriskEqualTerminal()
			: base("*=")
		{
		}
	}
}
