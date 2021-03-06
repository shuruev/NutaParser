﻿using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class TermPart : ParseAll
	{
		public static readonly TermPart S = new TermPart();

		public TermPart()
			: base(
				new ParseAny(
					new LexicalTerminal(Percentage.S),
					TermPartDimension.S,
					new LexicalTerminal(Number.S),
					new LexicalTerminal(StringLiteral.S),
					new LexicalTerminal(Identifier.S),
					new LexicalTerminal(UriLiteral.S)),
				Whitespaces.O)
		{
		}
	}
}
