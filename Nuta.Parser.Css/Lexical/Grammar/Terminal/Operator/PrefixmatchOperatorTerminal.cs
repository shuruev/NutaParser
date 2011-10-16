using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class PrefixmatchOperatorTerminal : LexicalItem
	{
		public static readonly PrefixmatchOperatorTerminal S = new PrefixmatchOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "^=");
		}
	}
}
