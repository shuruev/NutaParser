using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class IdentifierPartCharacter : ParseAny
	{
		public static readonly IdentifierPartCharacter S = new IdentifierPartCharacter();

		public IdentifierPartCharacter()
			: base(
				LetterCharacter.S,
				DecimalDigitCharacter.S,
				ConnectingCharacter.S,
				CombiningCharacter.S,
				FormattingCharacter.S)
		{
		}
	}
}
