using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
