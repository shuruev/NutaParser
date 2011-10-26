using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Media : ParseAll
	{
		public static readonly Media S = new Media();

		public Media()
			: base(
				new LexicalTerminal(MediaSymbol.S),
				WhitespaceTerminal.O,
				MediaQueryList.O,
				LeftCurlyBracketTerminal.S,
				WhitespaceTerminal.O,
				new Optional(new ParseMany(Ruleset.S)),
				RightCurlyBracketTerminal.S,
				WhitespaceTerminal.O)
		{
		}
	}
}
