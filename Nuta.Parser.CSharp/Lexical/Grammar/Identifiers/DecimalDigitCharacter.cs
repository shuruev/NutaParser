using System.Globalization;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class DecimalDigitCharacter : ParseAny
	{
		public static readonly DecimalDigitCharacter S = new DecimalDigitCharacter();

		public DecimalDigitCharacter()
			: base(
				new UnicodeEscapeSequenceCategory(UnicodeCategory.DecimalDigitNumber),
				new CharacterCategoryTerminal(UnicodeCategory.DecimalDigitNumber))
		{
		}
	}
}
