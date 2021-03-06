﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class ChecksumGuid : ParseAll
	{
		public static readonly ChecksumGuid S = new ChecksumGuid();

		public ChecksumGuid()
			: base(
				QuoteTerminal.S,
				LeftCurlyBracketTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HyphenTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HyphenTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HyphenTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HyphenTerminal.S,
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
				RightCurlyBracketTerminal.S,
				QuoteTerminal.S)
		{
		}
	}
}
