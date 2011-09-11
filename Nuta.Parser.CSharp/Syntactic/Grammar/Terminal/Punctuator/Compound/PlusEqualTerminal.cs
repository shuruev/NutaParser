using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PlusEqualTerminal : TextTerminal
	{
		public static readonly PlusEqualTerminal S = new PlusEqualTerminal();

		public PlusEqualTerminal()
			: base("+=")
		{
		}
	}
}
