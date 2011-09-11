using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ModuleTerminal : TextTerminal
	{
		public static readonly ModuleTerminal S = new ModuleTerminal();

		public ModuleTerminal()
			: base("module")
		{
		}
	}
}
