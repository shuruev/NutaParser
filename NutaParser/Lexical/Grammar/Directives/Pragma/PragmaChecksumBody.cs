using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PragmaChecksumBody : ParseAll
	{
		public static readonly PragmaChecksumBody S = new PragmaChecksumBody();

		public PragmaChecksumBody()
			: base(
				ChecksumTerminal.S,
				Whitespace.S,
				FileName.S,
				Whitespace.S,
				ChecksumGuid.S,
				Whitespace.S,
				ChecksumBytes.S)
		{
		}
	}
}
