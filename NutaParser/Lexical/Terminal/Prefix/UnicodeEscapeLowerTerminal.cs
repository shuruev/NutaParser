namespace NutaParser.Lexical.Grammar
{
	public class UnicodeEscapeUpperTerminal : LexicalItem
	{
		public static readonly UnicodeEscapeUpperTerminal S = new UnicodeEscapeUpperTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, @"\U");
		}
	}
}
