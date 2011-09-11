using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class UndefTerminal : LexicalItem
	{
		public static readonly UndefTerminal S = new UndefTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "undef");
		}
	}
}
