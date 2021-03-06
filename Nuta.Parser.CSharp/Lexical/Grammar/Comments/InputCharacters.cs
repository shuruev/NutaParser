﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class InputCharacters : ParseMany
	{
		public static readonly InputCharacters S = new InputCharacters();
		public static readonly Optional O = new Optional(S);

		public InputCharacters()
			: base(InputCharacter.S)
		{
		}
	}
}
