using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class IsTerminal : TextTerminal
	{
		public static readonly IsTerminal S = new IsTerminal();

		public IsTerminal()
			: base("is")
		{
		}
	}
}
