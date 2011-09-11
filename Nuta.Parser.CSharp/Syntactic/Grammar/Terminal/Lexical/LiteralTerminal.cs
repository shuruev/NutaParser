using Nuta.Parser.CSharp.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
