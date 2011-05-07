namespace NutaParser.Lexical.Grammar
{
	public class IdentifierPartCharacter : LexicalItem
	{
		public static readonly IdentifierPartCharacter S = new IdentifierPartCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				LetterCharacter.S,
				DecimalDigitCharacter.S,
				ConnectingCharacter.S,
				CombiningCharacter.S,
				FormattingCharacter.S);
		}
	}
}
