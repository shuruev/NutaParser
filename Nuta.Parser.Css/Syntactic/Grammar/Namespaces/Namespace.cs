using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Namespace : ParseAll
	{
		public static readonly Namespace S = new Namespace();

		public Namespace()
			: base(
				new LexicalTerminal(NamespaceSymbol.S),
				Whitespaces.O,
				new Optional(
					new ParseAll(
						NamespaceName.S,
						Whitespaces.O)),
				new ParseAny(
					new LexicalTerminal(StringLiteral.S),
					new LexicalTerminal(UriLiteral.S)),
				Whitespaces.O,
				SemicolonTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
