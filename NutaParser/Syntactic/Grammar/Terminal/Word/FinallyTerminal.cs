using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class FinallyTerminal : TextTerminal
	{
		public static readonly FinallyTerminal S = new FinallyTerminal();

		public FinallyTerminal()
			: base("finally")
		{
		}
	}
}
