using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class GotoStatement : ParseAll
	{
		public static readonly GotoStatement S = new GotoStatement();

		public GotoStatement()
			: base(
				GotoTerminal.S,
				new ParseAny(
					IdentifierTerminal.S,
					new ParseAll(CaseTerminal.S, ConstantExpression.S),
					DefaultTerminal.S),
				SemicolonTerminal.S)
		{
		}
	}
}
