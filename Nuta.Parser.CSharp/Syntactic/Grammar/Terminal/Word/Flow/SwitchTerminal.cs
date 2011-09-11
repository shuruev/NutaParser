using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SwitchTerminal : TextTerminal
	{
		public static readonly SwitchTerminal S = new SwitchTerminal();

		public SwitchTerminal()
			: base("switch")
		{
		}
	}
}
