using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class CatchTerminal : TextTerminal
	{
		public static readonly CatchTerminal S = new CatchTerminal();

		public CatchTerminal()
			: base("catch")
		{
		}
	}
}
