﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class DelimitedComment : ParseAll
	{
		public static readonly DelimitedComment S = new DelimitedComment();

		public DelimitedComment()
			: base(
				SlashTerminal.S,
				AsteriskTerminal.S,
				DelimitedCommentText.O,
				Asterisks.S,
				SlashTerminal.S)
		{
		}
	}
}
