using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class BarTerminal : TextTerminal
	{
		public static readonly BarTerminal S = new BarTerminal();

		public BarTerminal()
			: base("|")
		{
		}
	}
}
