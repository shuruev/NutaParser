namespace NutaParser.Lexical.Grammar
{
	public class IdentifierStartCharacter : LexicalItem
	{
		public static readonly IdentifierStartCharacter S = new IdentifierStartCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				LetterCharacter.S,
				UnderscoreTerminal.S);
		}
	}
}
