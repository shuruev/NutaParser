using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ContinueTerminal : TextTerminal
	{
		public static readonly ContinueTerminal S = new ContinueTerminal();

		public ContinueTerminal()
			: base("continue")
		{
		}
	}
}
