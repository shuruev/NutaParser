using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class EqualOperatorTerminal : LexicalItem
	{
		public static readonly EqualOperatorTerminal S = new EqualOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "==");
		}
	}
}
