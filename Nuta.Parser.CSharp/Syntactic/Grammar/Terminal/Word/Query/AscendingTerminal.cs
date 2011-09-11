using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AscendingTerminal : TextTerminal
	{
		public static readonly AscendingTerminal S = new AscendingTerminal();

		public AscendingTerminal()
			: base("ascending")
		{
		}
	}
}
