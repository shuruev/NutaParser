﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class RegularStringLiteralCharacter : ParseAny
	{
		public static readonly RegularStringLiteralCharacter S = new RegularStringLiteralCharacter();

		public RegularStringLiteralCharacter()
			: base(
				UnicodeEscapeSequence.S,
				HexadecimalEscapeSequence.S,
				SimpleEscapeSequence.S,
				SingleRegularStringLiteralCharacter.S)
		{
		}
	}
}
