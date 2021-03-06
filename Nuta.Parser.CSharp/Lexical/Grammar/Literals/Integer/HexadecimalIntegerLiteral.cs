﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class HexadecimalIntegerLiteral : ParseAll
	{
		public static readonly HexadecimalIntegerLiteral S = new HexadecimalIntegerLiteral();

		public HexadecimalIntegerLiteral()
			: base(
				new SingleCharacterTerminal('0'),
				new SingleCharacterTerminal('x', 'X'),
				HexDigits.S,
				IntegerTypeSuffix.O)
		{
		}
	}
}
