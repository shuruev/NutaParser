using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class ElseTerminal : LexicalItem
	{
		public static readonly ElseTerminal S = new ElseTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "else");
		}
	}
}
