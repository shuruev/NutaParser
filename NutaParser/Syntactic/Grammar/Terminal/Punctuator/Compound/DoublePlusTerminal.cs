using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DoublePlusTerminal : TextTerminal
	{
		public static readonly DoublePlusTerminal S = new DoublePlusTerminal();

		public DoublePlusTerminal()
			: base("++")
		{
		}
	}
}
