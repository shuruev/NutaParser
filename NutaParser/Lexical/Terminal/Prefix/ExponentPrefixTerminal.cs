namespace NutaParser.Lexical.Grammar
{
	public class ExponentPrefixTerminal : LexicalItem
	{
		public static readonly ExponentPrefixTerminal S = new ExponentPrefixTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => c == 'e' || c == 'E');
		}
	}
}
