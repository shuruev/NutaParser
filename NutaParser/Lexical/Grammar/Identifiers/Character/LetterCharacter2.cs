using System;
using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class LetterCharacter2 : LexicalItem
	{
		public static readonly LetterCharacter2 S = new LetterCharacter2();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => Char.GetUnicodeCategory(c) == UnicodeCategory.UppercaseLetter
					|| Char.GetUnicodeCategory(c) == UnicodeCategory.LowercaseLetter
					|| Char.GetUnicodeCategory(c) == UnicodeCategory.TitlecaseLetter
					|| Char.GetUnicodeCategory(c) == UnicodeCategory.ModifierLetter
					|| Char.GetUnicodeCategory(c) == UnicodeCategory.OtherLetter
					|| Char.GetUnicodeCategory(c) == UnicodeCategory.LetterNumber);
		}
	}
}
