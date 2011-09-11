using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PpNewLine : ParseAll
	{
		public static readonly PpNewLine S = new PpNewLine();

		public PpNewLine()
			: base(Whitespace.O, SingleLineComment.O, NewLine.S)
		{
		}
	}
}
