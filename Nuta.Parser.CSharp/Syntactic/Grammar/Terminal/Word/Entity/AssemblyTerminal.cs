using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AssemblyTerminal : TextTerminal
	{
		public static readonly AssemblyTerminal S = new AssemblyTerminal();

		public AssemblyTerminal()
			: base("assembly")
		{
		}
	}
}
