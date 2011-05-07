using System;
using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class DecimalDigitCharacter2 : LexicalItem
	{
		public static readonly DecimalDigitCharacter2 S = new DecimalDigitCharacter2();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => Char.GetUnicodeCategory(c) == UnicodeCategory.DecimalDigitNumber);
		}
	}
}
