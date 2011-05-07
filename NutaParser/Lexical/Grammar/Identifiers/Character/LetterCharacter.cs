namespace NutaParser.Lexical.Grammar
{
	public class LetterCharacter : LexicalItem
	{
		public static readonly LetterCharacter S = new LetterCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				LetterCharacter1.S,
				LetterCharacter2.S);
		}
	}
}
