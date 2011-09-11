using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ContinueStatement : ParseAll
	{
		public static readonly ContinueStatement S = new ContinueStatement();

		public ContinueStatement()
			: base(
				ContinueTerminal.S,
				SemicolonTerminal.S)
		{
		}
	}
}
