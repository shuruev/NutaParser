using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SetTerminal : TextTerminal
	{
		public static readonly SetTerminal S = new SetTerminal();

		public SetTerminal()
			: base("set")
		{
		}
	}
}
