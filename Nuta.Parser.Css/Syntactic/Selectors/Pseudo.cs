using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Pseudo : ParseAll
	{
		public static readonly Pseudo S = new Pseudo();

		public Pseudo()
			: base(
				ColonTerminal.S,
				ColonTerminal.O,
				new ParseAny(
					PseudoFunction.S,
					new LexicalTerminal(Identifier.S)))
		{
		}
	}
}
