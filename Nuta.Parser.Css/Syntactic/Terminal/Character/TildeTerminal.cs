﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class TildeTerminal : TextTerminal
	{
		public static readonly TildeTerminal S = new TildeTerminal();

		public TildeTerminal()
			: base("~")
		{
		}
	}
}
