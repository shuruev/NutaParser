using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SelectTerminal : TextTerminal
	{
		public static readonly SelectTerminal S = new SelectTerminal();

		public SelectTerminal()
			: base("select")
		{
		}
	}
}
