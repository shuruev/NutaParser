using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Comment : ParseAll
	{
		public static readonly Comment S = new Comment();

		public Comment()
			: base(
				SlashTerminal.S,
				AsteriskTerminal.S,
				NonAsteriskCharacters.O,
				Asterisks.S,
				CommentParts.O,
				SlashTerminal.S)
		{
		}
	}
}
