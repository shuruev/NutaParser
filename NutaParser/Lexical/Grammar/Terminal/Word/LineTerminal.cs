using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class LineTerminal : LexicalItem
	{
		public static readonly LineTerminal S = new LineTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "line");
		}
	}
}
