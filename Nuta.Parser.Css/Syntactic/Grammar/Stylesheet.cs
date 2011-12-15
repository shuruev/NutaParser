using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Stylesheet : ParseAll
	{
		public static readonly Stylesheet S = new Stylesheet();

		public Stylesheet()
			: base(
				new Optional(
					new ParseAll(
						new LexicalTerminal(CharsetSymbol.S),
						new LexicalTerminal(Whitespace.S),
						new LexicalTerminal(StringLiteral.S),
						SemicolonTerminal.S)),
				StylesheetWhitespace.O,
				new Optional(
					new ParseMany(
						new ParseAll(
							Import.S,
							StylesheetWhitespace.O))),
				new Optional(
					new ParseMany(
						new ParseAll(
							Namespace.S,
							StylesheetWhitespace.O))),
				new Optional(
					new ParseMany(
						new ParseAll(
							new ParseAny(
								Ruleset.S,
								Media.S,
								FontFace.S,
								Page.S,
								KeyframesRule.S),
							StylesheetWhitespace.O))))
		{
		}
	}
}
