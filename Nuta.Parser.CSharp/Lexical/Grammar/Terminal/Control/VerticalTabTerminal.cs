﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class VerticalTabTerminal : SingleCharacterTerminal
	{
		public static readonly VerticalTabTerminal S = new VerticalTabTerminal();

		public VerticalTabTerminal()
			: base('\x000B')
		{
		}
	}
}
