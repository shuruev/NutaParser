using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class VirtualTerminal : TextTerminal
	{
		public static readonly VirtualTerminal S = new VirtualTerminal();

		public VirtualTerminal()
			: base("virtual")
		{
		}
	}
}
