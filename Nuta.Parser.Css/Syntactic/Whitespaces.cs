using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Whitespaces : ParseMany
	{
		public static readonly Whitespaces S = new Whitespaces();
		public static readonly Optional O = new Optional(S);

		public Whitespaces()
			: base(
				new LexicalTerminal(Whitespace.S))
		{
		}
	}
}
