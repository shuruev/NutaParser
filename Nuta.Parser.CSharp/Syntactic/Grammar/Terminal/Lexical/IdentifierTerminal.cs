using Nuta.Parser.CSharp.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
