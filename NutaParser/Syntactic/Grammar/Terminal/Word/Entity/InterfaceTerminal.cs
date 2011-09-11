using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
