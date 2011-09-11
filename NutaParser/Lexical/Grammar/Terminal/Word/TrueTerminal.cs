using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class TrueTerminal : LexicalItem
	{
		public static readonly TrueTerminal S = new TrueTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "true");
		}
	}
}
