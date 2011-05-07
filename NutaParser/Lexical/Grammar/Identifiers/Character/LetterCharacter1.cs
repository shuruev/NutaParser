using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class LetterCharacter1 : LexicalItem
	{
		public static readonly LetterCharacter1 S = new LetterCharacter1();

		public override bool Parse(LexicalState state)
		{
			return UnicodeEscapeSequence.S.ParseCharacterCategory(
				state,
				Key,
				UnicodeCategory.UppercaseLetter,
				UnicodeCategory.LowercaseLetter,
				UnicodeCategory.TitlecaseLetter,
				UnicodeCategory.ModifierLetter,
				UnicodeCategory.OtherLetter,
				UnicodeCategory.LetterNumber);
		}
	}
}
