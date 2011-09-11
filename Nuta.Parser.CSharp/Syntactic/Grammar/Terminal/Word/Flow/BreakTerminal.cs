using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class BreakTerminal : TextTerminal
	{
		public static readonly BreakTerminal S = new BreakTerminal();

		public BreakTerminal()
			: base("break")
		{
		}
	}
}
