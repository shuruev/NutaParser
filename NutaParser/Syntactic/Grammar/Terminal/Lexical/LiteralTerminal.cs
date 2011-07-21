using NutaParser.Lexical.Grammar;

namespace NutaParser.Syntactic.Grammar
{
	public class LiteralTerminal : LexicalTerminal
	{
		public static readonly LiteralTerminal S = new LiteralTerminal();

		public LiteralTerminal()
			: base(Literal.S)
		{
		}
	}
}
