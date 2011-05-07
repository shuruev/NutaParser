using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class DecimalDigitCharacter1 : LexicalItem
	{
		public static readonly DecimalDigitCharacter1 S = new DecimalDigitCharacter1();

		public override bool Parse(LexicalState state)
		{
			return UnicodeEscapeSequence.S.ParseCharacterCategory(
				state,
				Key,
				UnicodeCategory.DecimalDigitNumber);
		}
	}
}
