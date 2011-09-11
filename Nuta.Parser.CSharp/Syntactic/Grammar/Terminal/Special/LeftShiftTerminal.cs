using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LeftShiftTerminal : TextTerminal
	{
		public static readonly LeftShiftTerminal S = new LeftShiftTerminal();

		public LeftShiftTerminal()
			: base("<<")
		{
		}
	}
}
