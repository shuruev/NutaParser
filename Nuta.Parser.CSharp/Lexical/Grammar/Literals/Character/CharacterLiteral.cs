﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class CharacterLiteral : ParseAll
	{
		public static readonly CharacterLiteral S = new CharacterLiteral();

		public CharacterLiteral()
			: base(ApostropheTerminal.S, Character.S, ApostropheTerminal.S)
		{
		}
	}
}
