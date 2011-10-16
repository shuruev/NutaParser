using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class SuffixmatchOperatorTerminal : LexicalItem
	{
		public static readonly SuffixmatchOperatorTerminal S = new SuffixmatchOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "$=");
		}
	}
}
