﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class Comment : LexicalItem
	{
		public static readonly Comment S = new Comment();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				SingleLineComment.S,
				DelimitedComment.S);
		}
	}
}
