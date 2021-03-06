﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Attribute : ParseAll
	{
		public static readonly Attribute S = new Attribute();

		public Attribute()
			: base(
				LeftSquareBracketTerminal.S,
				Whitespaces.O,
				NamespacePrefix.O,
				IdentifierTerminal.S,
				Whitespaces.O,
				AttributePart.O,
				RightSquareBracketTerminal.S)
		{
		}
	}
}
