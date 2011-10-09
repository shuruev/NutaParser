using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class PseudoClass : ParseAll
	{
		public static readonly PseudoClass S = new PseudoClass();

		public PseudoClass()
			: base(
				ColonTerminal.S,
				new ParseAny(
					new LexicalTerminal(Identifier.S),
					new ParseAll(
						new LexicalTerminal(FunctionPrefix.S),
						WhitespaceTerminal.O,
						PseudoClassPart.O,
						RightRoundBracketTerminal.S)))
		{
		}
	}
}
