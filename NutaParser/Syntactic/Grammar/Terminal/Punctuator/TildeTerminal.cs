using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TildeTerminal : TextTerminal
	{
		public static readonly TildeTerminal S = new TildeTerminal();

		public TildeTerminal()
			: base("~")
		{
		}
	}
}
