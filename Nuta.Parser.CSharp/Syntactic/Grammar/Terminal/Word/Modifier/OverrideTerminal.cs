using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OverrideTerminal : TextTerminal
	{
		public static readonly OverrideTerminal S = new OverrideTerminal();

		public OverrideTerminal()
			: base("override")
		{
		}
	}
}
