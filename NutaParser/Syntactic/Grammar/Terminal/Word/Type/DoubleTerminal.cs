using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DoubleTerminal : TextTerminal
	{
		public static readonly DoubleTerminal S = new DoubleTerminal();

		public DoubleTerminal()
			: base("double")
		{
		}
	}
}
