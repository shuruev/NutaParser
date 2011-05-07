using System;
using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class FormattingCharacter2 : LexicalItem
	{
		public static readonly FormattingCharacter2 S = new FormattingCharacter2();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => Char.GetUnicodeCategory(c) == UnicodeCategory.Format);
		}
	}
}
