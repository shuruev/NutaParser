using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ByTerminal : TextTerminal
	{
		public static readonly ByTerminal S = new ByTerminal();

		public ByTerminal()
			: base("by")
		{
		}
	}
}
