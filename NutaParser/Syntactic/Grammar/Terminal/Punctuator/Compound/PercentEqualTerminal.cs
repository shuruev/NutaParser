using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class PercentEqualTerminal : TextTerminal
	{
		public static readonly PercentEqualTerminal S = new PercentEqualTerminal();

		public PercentEqualTerminal()
			: base("%=")
		{
		}
	}
}
