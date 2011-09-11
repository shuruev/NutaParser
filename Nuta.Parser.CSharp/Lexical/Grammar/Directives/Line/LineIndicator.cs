using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class LineIndicator : ParseAny
	{
		public static readonly LineIndicator S = new LineIndicator();

		public LineIndicator()
			: base(
				new ParseAll(DecimalDigits.S, Whitespace.S, FileName.S),
				DecimalDigits.S,
				DefaultTerminal.S,
				HiddenTerminal.S)
		{
		}
	}
}
