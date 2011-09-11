using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class PpEndRegion : ParseAll
	{
		public static readonly PpEndRegion S = new PpEndRegion();

		public PpEndRegion()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				EndregionTerminal.S,
				PpMessage.S)
		{
		}
	}
}
