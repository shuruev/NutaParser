﻿using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class Input : ParseAll
	{
		public static readonly Input S = new Input();

		public Input()
			: base(InputSection.O)
		{
		}
	}
}
