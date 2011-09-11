﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class FileName : ParseAll
	{
		public static readonly FileName S = new FileName();

		public FileName()
			: base(QuoteTerminal.S, FileNameCharacters.S, QuoteTerminal.S)
		{
		}
	}
}
