using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class WhereTerminal : TextTerminal
	{
		public static readonly WhereTerminal S = new WhereTerminal();

		public WhereTerminal()
			: base("where")
		{
		}
	}
}
