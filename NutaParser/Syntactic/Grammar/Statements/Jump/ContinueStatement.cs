using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
