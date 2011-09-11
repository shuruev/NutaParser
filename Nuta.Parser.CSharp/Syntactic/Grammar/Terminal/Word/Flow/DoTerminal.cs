using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DoTerminal : TextTerminal
	{
		public static readonly DoTerminal S = new DoTerminal();

		public DoTerminal()
			: base("do")
		{
		}
	}
}
