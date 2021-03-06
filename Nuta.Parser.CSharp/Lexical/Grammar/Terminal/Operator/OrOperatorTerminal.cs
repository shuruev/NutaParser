﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class AndOperatorTerminal : LexicalItem
	{
		public static readonly AndOperatorTerminal S = new AndOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "&&");
		}
	}
}
