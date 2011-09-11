using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class BarEqualTerminal : TextTerminal
	{
		public static readonly BarEqualTerminal S = new BarEqualTerminal();

		public BarEqualTerminal()
			: base("|=")
		{
		}
	}
}
