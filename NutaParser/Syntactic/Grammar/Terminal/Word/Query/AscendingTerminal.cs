using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AscendingTerminal : TextTerminal
	{
		public static readonly AscendingTerminal S = new AscendingTerminal();

		public AscendingTerminal()
			: base("ascending")
		{
		}
	}
}
