using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class GotoTerminal : TextTerminal
	{
		public static readonly GotoTerminal S = new GotoTerminal();

		public GotoTerminal()
			: base("goto")
		{
		}
	}
}
