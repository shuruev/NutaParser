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
				WhitespaceTerminal.O,
				new Optional(
					new ParseAll(
						NamespaceName.S,
						WhitespaceTerminal.O)),
				new ParseAny(
					new LexicalTerminal(StringLiteral.S),
					new LexicalTerminal(UriLiteral.S)),
				WhitespaceTerminal.O,
				SemicolonTerminal.S,
				WhitespaceTerminal.O)
		{
		}
	}
}
