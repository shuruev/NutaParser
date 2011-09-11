using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
