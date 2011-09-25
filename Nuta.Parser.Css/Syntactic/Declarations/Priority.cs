using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Priority : ParseAll
	{
		public static readonly Priority S = new Priority();
		public static readonly Optional O = new Optional(S);

		public Priority()
			: base(
				new LexicalTerminal(ImportantSymbol.S),
				WhitespaceTerminal.O)
		{
		}
	}
}
