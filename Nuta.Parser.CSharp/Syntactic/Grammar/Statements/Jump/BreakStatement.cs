using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class BreakStatement : ParseAll
	{
		public static readonly BreakStatement S = new BreakStatement();

		public BreakStatement()
			: base(
				BreakTerminal.S,
				SemicolonTerminal.S)
		{
		}
	}
}
