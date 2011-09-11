using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class VoidTerminal : TextTerminal
	{
		public static readonly VoidTerminal S = new VoidTerminal();

		public VoidTerminal()
			: base("void")
		{
		}
	}
}
