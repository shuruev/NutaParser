using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DoubleEqualTerminal : TextTerminal
	{
		public static readonly DoubleEqualTerminal S = new DoubleEqualTerminal();

		public DoubleEqualTerminal()
			: base("==")
		{
		}
	}
}
