using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class CheckedTerminal : TextTerminal
	{
		public static readonly CheckedTerminal S = new CheckedTerminal();

		public CheckedTerminal()
			: base("checked")
		{
		}
	}
}
