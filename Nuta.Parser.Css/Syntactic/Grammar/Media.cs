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
				Whitespaces.O,
				MediaQueryList.O,
				LeftCurlyBracketTerminal.S,
				Whitespaces.O,
				new Optional(
					new ParseMany(
						new ParseAny(
							Ruleset.S,
							Page.S))),
				RightCurlyBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
