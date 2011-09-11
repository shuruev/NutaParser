using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ReturnTerminal : TextTerminal
	{
		public static readonly ReturnTerminal S = new ReturnTerminal();

		public ReturnTerminal()
			: base("return")
		{
		}
	}
}
