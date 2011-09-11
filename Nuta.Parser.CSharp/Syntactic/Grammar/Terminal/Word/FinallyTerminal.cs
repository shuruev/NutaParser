using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FinallyTerminal : TextTerminal
	{
		public static readonly FinallyTerminal S = new FinallyTerminal();

		public FinallyTerminal()
			: base("finally")
		{
		}
	}
}
