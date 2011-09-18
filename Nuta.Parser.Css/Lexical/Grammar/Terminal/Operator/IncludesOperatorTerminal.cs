using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class IncludesOperatorTerminal : LexicalItem
	{
		public static readonly IncludesOperatorTerminal S = new IncludesOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "~=");
		}
	}
}
