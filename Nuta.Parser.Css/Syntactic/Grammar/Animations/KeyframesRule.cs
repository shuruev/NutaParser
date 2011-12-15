using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class KeyframesRule : ParseAll
	{
		public static readonly KeyframesRule S = new KeyframesRule();

		public KeyframesRule()
			: base(
				new LexicalTerminal(KeyframesSymbol.S),
				Whitespaces.O,
				IdentifierTerminal.S,
				Whitespaces.O,
				LeftCurlyBracketTerminal.S,
				new ParseAny(
					new ParseMany(KeyframeBlock.S),
					Whitespaces.O),
				RightCurlyBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
