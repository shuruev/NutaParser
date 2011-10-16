using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class SubstringmatchOperatorTerminal : LexicalItem
	{
		public static readonly SubstringmatchOperatorTerminal S = new SubstringmatchOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "*=");
		}
	}
}
