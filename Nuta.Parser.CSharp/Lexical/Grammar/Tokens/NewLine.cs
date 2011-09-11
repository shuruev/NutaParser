using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class NewLine : ParseAny
	{
		public static readonly NewLine S = new NewLine();

		public NewLine()
			: base(
				new ParseAll(CarriageReturnTerminal.S, LineFeedTerminal.S),
				CarriageReturnTerminal.S,
				LineFeedTerminal.S,
				NextLineTerminal.S,
				LineSeparatorTerminal.S,
				ParagraphSeparatorTerminal.S)
		{
		}
	}
}
