using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class WhileTerminal : TextTerminal
	{
		public static readonly WhileTerminal S = new WhileTerminal();

		public WhileTerminal()
			: base("while")
		{
		}
	}
}
