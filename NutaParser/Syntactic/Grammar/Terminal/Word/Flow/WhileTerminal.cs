using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
