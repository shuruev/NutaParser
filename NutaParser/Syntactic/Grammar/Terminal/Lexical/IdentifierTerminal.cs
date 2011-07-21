using NutaParser.Lexical.Grammar;

namespace NutaParser.Syntactic.Grammar
{
	public class IdentifierTerminal : LexicalTerminal
	{
		public static readonly IdentifierTerminal S = new IdentifierTerminal();

		public IdentifierTerminal()
			: base(Identifier.S)
		{
		}
	}
}
