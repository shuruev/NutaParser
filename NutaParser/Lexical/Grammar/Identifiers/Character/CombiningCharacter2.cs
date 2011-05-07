using System;
using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class CombiningCharacter2 : LexicalItem
	{
		public static readonly CombiningCharacter2 S = new CombiningCharacter2();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => Char.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark
					|| Char.GetUnicodeCategory(c) == UnicodeCategory.SpacingCombiningMark);
		}
	}
}
