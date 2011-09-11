using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class UlongTerminal : TextTerminal
	{
		public static readonly UlongTerminal S = new UlongTerminal();

		public UlongTerminal()
			: base("ulong")
		{
		}
	}
}
