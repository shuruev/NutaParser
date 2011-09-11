using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PpEndif : ParseAll
	{
		public static readonly PpEndif S = new PpEndif();

		public PpEndif()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				EndifTerminal.S,
				PpNewLine.S)
		{
		}
	}
}
