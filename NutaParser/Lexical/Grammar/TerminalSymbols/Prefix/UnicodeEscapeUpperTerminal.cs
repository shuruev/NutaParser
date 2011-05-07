namespace NutaParser.Lexical.Grammar
{
	public class UnicodeEscapeLowerTerminal : LexicalItem
	{
		public static readonly UnicodeEscapeLowerTerminal S = new UnicodeEscapeLowerTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, @"\u");
		}
	}
}
