using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ReturnStatement : ParseAll
	{
		public static readonly ReturnStatement S = new ReturnStatement();

		public ReturnStatement()
			: base(
				ReturnTerminal.S,
				Expression.O,
				SemicolonTerminal.S)
		{
		}
	}
}
