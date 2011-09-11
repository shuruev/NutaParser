using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class OperatorTerminal : TextTerminal
	{
		public static readonly OperatorTerminal S = new OperatorTerminal();

		public OperatorTerminal()
			: base("operator")
		{
		}
	}
}
