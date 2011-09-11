using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
