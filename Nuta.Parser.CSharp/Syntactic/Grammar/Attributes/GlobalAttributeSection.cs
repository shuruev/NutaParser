﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class GlobalAttributeSection : ParseAll
	{
		public static readonly GlobalAttributeSection S = new GlobalAttributeSection();

		public GlobalAttributeSection()
			: base(
				LeftSquareBracketTerminal.S,
				GlobalAttributeTargetSpecifier.S,
				AttributeList.S,
				CommaTerminal.O,
				RightSquareBracketTerminal.S)
		{
		}
	}
}
