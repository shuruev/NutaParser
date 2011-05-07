using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class FormattingCharacter1 : LexicalItem
	{
		public static readonly FormattingCharacter1 S = new FormattingCharacter1();

		public override bool Parse(LexicalState state)
		{
			return UnicodeEscapeSequence.S.ParseCharacterCategory(
				state,
				Key,
				UnicodeCategory.Format);
		}
	}
}
