using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NewLine : ParseAny
	{
		public static readonly NewLine S = new NewLine();

		public NewLine()
			: base(
				new ParseAll(CarriageReturnTerminal.S, LineFeedTerminal.S),
				CarriageReturnTerminal.S,
				LineFeedTerminal.S,
				FormFeedTerminal.S)
		{
		}
	}
}
