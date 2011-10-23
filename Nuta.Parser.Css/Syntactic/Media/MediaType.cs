using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaType : ParseAll
	{
		public static readonly MediaType S = new MediaType();

		public MediaType()
			: base(new LexicalTerminal(Identifier.S))
		{
		}
	}
}
