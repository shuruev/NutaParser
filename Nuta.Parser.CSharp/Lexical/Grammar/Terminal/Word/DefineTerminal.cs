﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class DefineTerminal : LexicalItem
	{
		public static readonly DefineTerminal S = new DefineTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "define");
		}
	}
}
