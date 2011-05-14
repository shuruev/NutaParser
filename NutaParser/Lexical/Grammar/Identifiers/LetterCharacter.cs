using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class LetterCharacter : ParseAny
	{
		public static readonly LetterCharacter S = new LetterCharacter();

		public LetterCharacter()
			: base(
				new UnicodeEscapeSequenceCategory(
					UnicodeCategory.UppercaseLetter,
					UnicodeCategory.LowercaseLetter,
					UnicodeCategory.TitlecaseLetter,
					UnicodeCategory.ModifierLetter,
					UnicodeCategory.OtherLetter,
					UnicodeCategory.LetterNumber),
				new CharacterCategoryTerminal(
					UnicodeCategory.UppercaseLetter,
					UnicodeCategory.LowercaseLetter,
					UnicodeCategory.TitlecaseLetter,
					UnicodeCategory.ModifierLetter,
					UnicodeCategory.OtherLetter,
					UnicodeCategory.LetterNumber))
		{
		}
	}
}
