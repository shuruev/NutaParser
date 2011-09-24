using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Operator : ParseAll
	{
		public static readonly Operator S = new Operator();

		public Operator()
			: base(
				new ParseAny(
					new LexicalTerminal(SlashTerminal.S),
					new LexicalTerminal(CommaTerminal.S)),
				WhitespaceTerminal.O)
		{
		}
	}
}
