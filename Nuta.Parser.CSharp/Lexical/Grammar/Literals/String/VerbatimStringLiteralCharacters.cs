﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class VerbatimStringLiteralCharacters : ParseMany
	{
		public static readonly VerbatimStringLiteralCharacters S = new VerbatimStringLiteralCharacters();
		public static readonly Optional O = new Optional(S);

		public VerbatimStringLiteralCharacters()
			: base(VerbatimStringLiteralCharacter.S)
		{
		}
	}
}
