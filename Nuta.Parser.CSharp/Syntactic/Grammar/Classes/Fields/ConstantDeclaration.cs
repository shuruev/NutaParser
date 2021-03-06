﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConstantDeclaration : ParseAll
	{
		public static readonly ConstantDeclaration S = new ConstantDeclaration();

		public ConstantDeclaration()
			: base(
				Attributes.O,
				ConstantModifiers.O,
				ConstTerminal.S,
				Type.S,
				ConstantDeclarators.S,
				SemicolonTerminal.S)
		{
		}
	}
}
