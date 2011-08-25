namespace NutaParser.Syntactic.Grammar
{
	public class CaretTerminal : TextTerminal
	{
		public static readonly CaretTerminal S = new CaretTerminal();

		public CaretTerminal()
			: base("^")
		{
		}
	}
}
