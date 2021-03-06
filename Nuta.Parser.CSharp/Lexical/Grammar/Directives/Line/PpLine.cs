﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PpLine : ParseAll
	{
		public static readonly PpLine S = new PpLine();

		public PpLine()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				LineTerminal.S,
				Whitespace.S,
				LineIndicator.S,
				PpNewLine.S)
		{
		}
	}
}
