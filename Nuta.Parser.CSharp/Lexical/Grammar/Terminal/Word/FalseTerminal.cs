using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class FalseTerminal : LexicalItem
	{
		public static readonly FalseTerminal S = new FalseTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "false");
		}
	}
}
