using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class UncheckedTerminal : TextTerminal
	{
		public static readonly UncheckedTerminal S = new UncheckedTerminal();

		public UncheckedTerminal()
			: base("unchecked")
		{
		}
	}
}
