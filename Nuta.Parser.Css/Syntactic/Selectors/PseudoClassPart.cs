using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class PseudoClassPart : ParseAll
	{
		public static readonly PseudoClassPart S = new PseudoClassPart();
		public static readonly Optional O = new Optional(S);

		public PseudoClassPart()
			: base(
				new LexicalTerminal(Identifier.S),
				WhitespaceTerminal.O)
		{
		}
	}
}
