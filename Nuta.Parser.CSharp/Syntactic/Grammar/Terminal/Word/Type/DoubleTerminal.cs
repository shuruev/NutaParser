using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DoubleTerminal : TextTerminal
	{
		public static readonly DoubleTerminal S = new DoubleTerminal();

		public DoubleTerminal()
			: base("double")
		{
		}
	}
}
