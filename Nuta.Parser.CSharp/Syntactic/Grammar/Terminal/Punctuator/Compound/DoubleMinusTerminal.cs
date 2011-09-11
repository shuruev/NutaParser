using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DoubleMinusTerminal : TextTerminal
	{
		public static readonly DoubleMinusTerminal S = new DoubleMinusTerminal();

		public DoubleMinusTerminal()
			: base("--")
		{
		}
	}
}
