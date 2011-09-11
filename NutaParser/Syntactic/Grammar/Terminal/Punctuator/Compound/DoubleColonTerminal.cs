using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DoubleColonTerminal : TextTerminal
	{
		public static readonly DoubleColonTerminal S = new DoubleColonTerminal();

		public DoubleColonTerminal()
			: base("::")
		{
		}
	}
}
