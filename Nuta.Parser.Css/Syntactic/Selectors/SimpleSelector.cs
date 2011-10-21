using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SimpleSelector : ParseAny
	{
		public static readonly SimpleSelector S = new SimpleSelector();

		public SimpleSelector()
			: base(
				new LexicalTerminal(Hash.S),
				Class.S,
				Attribute.S,
				Negation.S,
				Pseudo.S)
		{
		}
	}
}
