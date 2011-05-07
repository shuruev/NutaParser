using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class ConnectingCharacter1 : LexicalItem
	{
		public static readonly ConnectingCharacter1 S = new ConnectingCharacter1();

		public override bool Parse(LexicalState state)
		{
			return UnicodeEscapeSequence.S.ParseCharacterCategory(
				state,
				Key,
				UnicodeCategory.ConnectorPunctuation);
		}
	}
}
