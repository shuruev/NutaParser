using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OutTerminal : TextTerminal
	{
		public static readonly OutTerminal S = new OutTerminal();

		public OutTerminal()
			: base("out")
		{
		}
	}
}
