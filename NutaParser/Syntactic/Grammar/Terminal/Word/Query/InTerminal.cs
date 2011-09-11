using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class InTerminal : TextTerminal
	{
		public static readonly InTerminal S = new InTerminal();

		public InTerminal()
			: base("in")
		{
		}
	}
}
