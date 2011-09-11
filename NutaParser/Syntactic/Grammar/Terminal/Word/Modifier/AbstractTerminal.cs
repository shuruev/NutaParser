using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AbstractTerminal : TextTerminal
	{
		public static readonly AbstractTerminal S = new AbstractTerminal();

		public AbstractTerminal()
			: base("abstract")
		{
		}
	}
}
