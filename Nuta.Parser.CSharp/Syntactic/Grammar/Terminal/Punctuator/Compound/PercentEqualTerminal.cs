using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PercentEqualTerminal : TextTerminal
	{
		public static readonly PercentEqualTerminal S = new PercentEqualTerminal();

		public PercentEqualTerminal()
			: base("%=")
		{
		}
	}
}
