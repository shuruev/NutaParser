﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class ElifTerminal : LexicalItem
	{
		public static readonly ElifTerminal S = new ElifTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "elif");
		}
	}
}
