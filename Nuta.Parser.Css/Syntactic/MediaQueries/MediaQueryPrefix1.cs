using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaQueryPrefix1 : ParseAll
	{
		public static readonly MediaQueryPrefix1 S = new MediaQueryPrefix1();

		public MediaQueryPrefix1()
			: base(
				new ParseAny(
					new LexicalTerminal(Only.S),
					new LexicalTerminal(Not.S),
					Empty.S),
				Whitespaces.O,
				MediaType.S,
				Whitespaces.O)
		{
		}
	}
}
