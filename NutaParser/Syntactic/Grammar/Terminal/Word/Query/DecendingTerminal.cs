using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DescendingTerminal : TextTerminal
	{
		public static readonly DescendingTerminal S = new DescendingTerminal();

		public DescendingTerminal()
			: base("descending")
		{
		}
	}
}
