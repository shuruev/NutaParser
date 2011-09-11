using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SelectTerminal : TextTerminal
	{
		public static readonly SelectTerminal S = new SelectTerminal();

		public SelectTerminal()
			: base("select")
		{
		}
	}
}
