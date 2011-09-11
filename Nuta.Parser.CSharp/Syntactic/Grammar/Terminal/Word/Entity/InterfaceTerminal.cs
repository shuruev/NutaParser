using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceTerminal : TextTerminal
	{
		public static readonly InterfaceTerminal S = new InterfaceTerminal();

		public InterfaceTerminal()
			: base("interface")
		{
		}
	}
}
