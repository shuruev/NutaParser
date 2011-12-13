using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class IdentifierTerminal : LexicalTerminal
	{
		public static readonly IdentifierTerminal S = new IdentifierTerminal();
		public static readonly Optional O = new Optional(S);

		public IdentifierTerminal()
			: base(Identifier.S)
		{
		}
	}
}
