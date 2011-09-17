using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class CommentPart : ParseAll
	{
		public static readonly CommentPart S = new CommentPart();

		public CommentPart()
			: base(
				NonAsteriskOrSlashCharacter.S,
				NonAsteriskCharacters.O,
				Asterisks.S)
		{
		}
	}
}
