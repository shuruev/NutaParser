﻿namespace NutaParser.Lexical.Grammar
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