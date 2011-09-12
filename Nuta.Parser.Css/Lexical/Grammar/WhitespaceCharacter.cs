using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class WhitespaceCharacter : ParseAny
	{
		public static readonly WhitespaceCharacter S = new WhitespaceCharacter();

		public WhitespaceCharacter()
			: base(
				SpaceTerminal.S,
				HorizontalTabTerminal.S,
				CarriageReturnTerminal.S,
				LineFeedTerminal.S,
				FormFeedTerminal.S)
		{
		}
	}
}
