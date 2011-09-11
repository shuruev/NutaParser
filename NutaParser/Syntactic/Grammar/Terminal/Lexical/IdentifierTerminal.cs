using Nuta.Parser.CSharp.Lexical.Grammar;

using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
