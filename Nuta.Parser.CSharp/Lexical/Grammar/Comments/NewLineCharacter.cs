﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class NewLineCharacter : ParseAny
	{
		public static readonly NewLineCharacter S = new NewLineCharacter();

		public NewLineCharacter()
			: base(
				CarriageReturnTerminal.S,
				LineFeedTerminal.S,
				NextLineTerminal.S,
				LineSeparatorTerminal.S,
				ParagraphSeparatorTerminal.S)
		{
		}
	}
}
