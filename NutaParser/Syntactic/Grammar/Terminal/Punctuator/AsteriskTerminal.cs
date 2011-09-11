using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AsteriskTerminal : TextTerminal
	{
		public static readonly AsteriskTerminal S = new AsteriskTerminal();

		public AsteriskTerminal()
			: base("*")
		{
		}
	}
}
