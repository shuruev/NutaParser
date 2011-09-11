﻿using System.Globalization;
using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class CombiningCharacter : ParseAny
	{
		public static readonly CombiningCharacter S = new CombiningCharacter();

		public CombiningCharacter()
			: base(
				new UnicodeEscapeSequenceCategory(
					UnicodeCategory.NonSpacingMark,
					UnicodeCategory.SpacingCombiningMark),
				new CharacterCategoryTerminal(
					UnicodeCategory.NonSpacingMark,
					UnicodeCategory.SpacingCombiningMark))
		{
		}
	}
}
