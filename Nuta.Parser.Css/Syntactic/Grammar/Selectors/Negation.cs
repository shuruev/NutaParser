﻿using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Negation : ParseAll
	{
		public static readonly Negation S = new Negation();

		public Negation()
			: base(
				new LexicalTerminal(NotPrefix.S),
				Whitespaces.O,
				NegationArgument.S,
				Whitespaces.O,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
