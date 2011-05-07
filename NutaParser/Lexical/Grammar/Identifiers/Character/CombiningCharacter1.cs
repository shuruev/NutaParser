using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class CombiningCharacter1 : LexicalItem
	{
		public static readonly CombiningCharacter1 S = new CombiningCharacter1();

		public override bool Parse(LexicalState state)
		{
			return UnicodeEscapeSequence.S.ParseCharacterCategory(
				state,
				Key,
				UnicodeCategory.NonSpacingMark,
				UnicodeCategory.SpacingCombiningMark);
		}
	}
}
