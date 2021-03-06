﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PpStartRegion : ParseAll
	{
		public static readonly PpStartRegion S = new PpStartRegion();

		public PpStartRegion()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				RegionTerminal.S,
				PpMessage.S)
		{
		}
	}
}
