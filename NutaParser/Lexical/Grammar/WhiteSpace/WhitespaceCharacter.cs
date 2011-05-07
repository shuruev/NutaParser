using System;
using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class WhitespaceCharacter : LexicalItem
	{
		public static readonly WhitespaceCharacter S = new WhitespaceCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => Char.GetUnicodeCategory(c) == UnicodeCategory.SpaceSeparator
					|| c == 0x0009
					|| c == 0x000B
					|| c == 0x000C);
		}
	}
}
