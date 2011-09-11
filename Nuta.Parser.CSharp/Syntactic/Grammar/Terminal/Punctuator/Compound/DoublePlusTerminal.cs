using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DoublePlusTerminal : TextTerminal
	{
		public static readonly DoublePlusTerminal S = new DoublePlusTerminal();

		public DoublePlusTerminal()
			: base("++")
		{
		}
	}
}
