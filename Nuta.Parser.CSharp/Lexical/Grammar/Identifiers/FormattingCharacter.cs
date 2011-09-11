using System.Globalization;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class FormattingCharacter : ParseAny
	{
		public static readonly FormattingCharacter S = new FormattingCharacter();

		public FormattingCharacter()
			: base(
				new UnicodeEscapeSequenceCategory(UnicodeCategory.Format),
				new CharacterCategoryTerminal(UnicodeCategory.Format))
		{
		}
	}
}
