using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
