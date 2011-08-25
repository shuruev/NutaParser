namespace NutaParser.Syntactic.Grammar
{
	public class CaretEqualTerminal : TextTerminal
	{
		public static readonly CaretEqualTerminal S = new CaretEqualTerminal();

		public CaretEqualTerminal()
			: base("^=")
		{
		}
	}
}
