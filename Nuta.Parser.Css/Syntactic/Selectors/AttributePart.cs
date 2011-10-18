using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class AttributePart : ParseAll
	{
		public static readonly AttributePart S = new AttributePart();
		public static readonly Optional O = new Optional(S);

		public AttributePart()
			: base(
				new ParseAny(
					EqualTerminal.S,
					new LexicalTerminal(IncludesOperatorTerminal.S),
					new LexicalTerminal(DashmatchOperatorTerminal.S),
					new LexicalTerminal(PrefixmatchOperatorTerminal.S),
					new LexicalTerminal(SuffixmatchOperatorTerminal.S),
					new LexicalTerminal(SubstringmatchOperatorTerminal.S)),
				WhitespaceTerminal.O,
				new ParseAny(
					new LexicalTerminal(Identifier.S),
					new LexicalTerminal(StringLiteral.S)),
				WhitespaceTerminal.O)
		{
		}
	}
}
