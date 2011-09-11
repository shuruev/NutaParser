using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class HiddenTerminal : LexicalItem
	{
		public static readonly HiddenTerminal S = new HiddenTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "hidden");
		}
	}
}
