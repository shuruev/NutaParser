using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class WhereTerminal : TextTerminal
	{
		public static readonly WhereTerminal S = new WhereTerminal();

		public WhereTerminal()
			: base("where")
		{
		}
	}
}
