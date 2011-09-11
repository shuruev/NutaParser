using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class YieldTerminal : TextTerminal
	{
		public static readonly YieldTerminal S = new YieldTerminal();

		public YieldTerminal()
			: base("yield")
		{
		}
	}
}
