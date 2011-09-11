using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ImplicationTerminal : TextTerminal
	{
		public static readonly ImplicationTerminal S = new ImplicationTerminal();

		public ImplicationTerminal()
			: base("=>")
		{
		}
	}
}
