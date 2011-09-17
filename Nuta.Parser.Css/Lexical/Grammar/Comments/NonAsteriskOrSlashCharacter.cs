using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NonAsteriskOrSlashCharacter : ParseExcept
	{
		public static readonly NonAsteriskOrSlashCharacter S = new NonAsteriskOrSlashCharacter();

		public NonAsteriskOrSlashCharacter()
			: base(
				AnyCharacterTerminal.S,
				new ParseAny(
					SlashTerminal.S,
					AsteriskTerminal.S))
		{
		}
	}
}
