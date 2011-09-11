using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class EndregionTerminal : LexicalItem
	{
		public static readonly EndregionTerminal S = new EndregionTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "endregion");
		}
	}
}
