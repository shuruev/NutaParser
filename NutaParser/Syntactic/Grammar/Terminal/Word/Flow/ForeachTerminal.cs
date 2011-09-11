using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ForeachTerminal : TextTerminal
	{
		public static readonly ForeachTerminal S = new ForeachTerminal();

		public ForeachTerminal()
			: base("foreach")
		{
		}
	}
}
