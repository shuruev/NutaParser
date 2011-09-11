using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ForTerminal : TextTerminal
	{
		public static readonly ForTerminal S = new ForTerminal();

		public ForTerminal()
			: base("for")
		{
		}
	}
}
