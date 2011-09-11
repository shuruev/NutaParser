﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class ParagraphSeparatorTerminal : SingleCharacterTerminal
	{
		public static readonly ParagraphSeparatorTerminal S = new ParagraphSeparatorTerminal();

		public ParagraphSeparatorTerminal()
			: base('\x2029')
		{
		}
	}
}
