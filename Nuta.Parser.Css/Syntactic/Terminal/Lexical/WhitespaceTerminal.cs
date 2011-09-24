using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class WhitespaceTerminal : LexicalTerminal
	{
		public static readonly WhitespaceTerminal S = new WhitespaceTerminal();
		public static readonly Optional O = new Optional(S);

		public WhitespaceTerminal()
			: base(Whitespace.S)
		{
		}
	}
}
