using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class ChecksumBytes : ParseAll
	{
		public static readonly ChecksumBytes S = new ChecksumBytes();

		public ChecksumBytes()
			: base(
				QuoteTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				QuoteTerminal.S)
		{
		}
	}
}
