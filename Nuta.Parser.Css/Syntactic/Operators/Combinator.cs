using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Combinator : ParseAll
	{
		public static readonly Combinator S = new Combinator();

		public Combinator()
			: base(
				new ParseAny(
					new LexicalTerminal(PlusTerminal.S),
					new LexicalTerminal(RightAngleBracketTerminal.S)),
				WhitespaceTerminal.O)
		{
		}
	}
}
