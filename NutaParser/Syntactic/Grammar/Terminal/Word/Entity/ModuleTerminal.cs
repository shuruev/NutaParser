using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
