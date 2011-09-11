using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class BoolTerminal : TextTerminal
	{
		public static readonly BoolTerminal S = new BoolTerminal();

		public BoolTerminal()
			: base("bool")
		{
		}
	}
}
