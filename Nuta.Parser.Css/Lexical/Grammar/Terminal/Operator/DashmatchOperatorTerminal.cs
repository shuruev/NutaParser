using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class DashmatchOperatorTerminal : LexicalItem
	{
		public static readonly DashmatchOperatorTerminal S = new DashmatchOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "|=");
		}
	}
}
