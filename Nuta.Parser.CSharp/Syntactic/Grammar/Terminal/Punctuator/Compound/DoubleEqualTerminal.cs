using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DoubleEqualTerminal : TextTerminal
	{
		public static readonly DoubleEqualTerminal S = new DoubleEqualTerminal();

		public DoubleEqualTerminal()
			: base("==")
		{
		}
	}
}
