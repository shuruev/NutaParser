using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class VarTerminal : TextTerminal
	{
		public static readonly VarTerminal S = new VarTerminal();

		public VarTerminal()
			: base("var")
		{
		}
	}
}
