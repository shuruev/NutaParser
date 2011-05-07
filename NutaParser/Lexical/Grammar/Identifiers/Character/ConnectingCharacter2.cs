using System;
using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class ConnectingCharacter2 : LexicalItem
	{
		public static readonly ConnectingCharacter2 S = new ConnectingCharacter2();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => Char.GetUnicodeCategory(c) == UnicodeCategory.ConnectorPunctuation);
		}
	}
}
