﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class AsteriskTerminal : SingleCharacterTerminal
	{
		public static readonly AsteriskTerminal S = new AsteriskTerminal();

		public AsteriskTerminal()
			: base('*')
		{
		}
	}
}
