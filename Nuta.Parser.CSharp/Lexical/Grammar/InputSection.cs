﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class InputSection : ParseMany
	{
		public static readonly InputSection S = new InputSection();
		public static readonly Optional O = new Optional(S);

		public InputSection()
			: base(InputSectionPart.S)
		{
		}
	}
}
