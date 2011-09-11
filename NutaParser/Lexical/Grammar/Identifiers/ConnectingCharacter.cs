﻿using System.Globalization;
using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class ConnectingCharacter : ParseAny
	{
		public static readonly ConnectingCharacter S = new ConnectingCharacter();

		public ConnectingCharacter()
			: base(
				new UnicodeEscapeSequenceCategory(UnicodeCategory.ConnectorPunctuation),
				new CharacterCategoryTerminal(UnicodeCategory.ConnectorPunctuation))
		{
		}
	}
}
