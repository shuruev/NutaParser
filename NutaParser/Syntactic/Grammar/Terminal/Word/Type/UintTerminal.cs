using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class UintTerminal : TextTerminal
	{
		public static readonly UintTerminal S = new UintTerminal();

		public UintTerminal()
			: base("uint")
		{
		}
	}
}
