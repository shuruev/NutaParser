using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class GreaterOrEqualTerminal : TextTerminal
	{
		public static readonly GreaterOrEqualTerminal S = new GreaterOrEqualTerminal();

		public GreaterOrEqualTerminal()
			: base(">=")
		{
		}
	}
}
