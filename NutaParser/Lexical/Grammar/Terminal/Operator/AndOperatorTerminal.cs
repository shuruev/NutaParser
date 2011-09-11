using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class OrOperatorTerminal : LexicalItem
	{
		public static readonly OrOperatorTerminal S = new OrOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "||");
		}
	}
}
