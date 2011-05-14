using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class WhitespaceCharacter : ParseAny
	{
		public static readonly WhitespaceCharacter S = new WhitespaceCharacter();

		public WhitespaceCharacter()
			: base(
				new CharacterCategoryTerminal(UnicodeCategory.SpaceSeparator),
				HorizontalTabTerminal.S,
				VerticalTabTerminal.S,
				FormFeedTerminal.S)
		{
		}
	}
}
