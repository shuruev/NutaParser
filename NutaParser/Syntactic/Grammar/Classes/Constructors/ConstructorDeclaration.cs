﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ConstructorDeclaration : ParseAll
	{
		public static readonly ConstructorDeclaration S = new ConstructorDeclaration();

		public ConstructorDeclaration()
			: base(
				Attributes.O,
				ConstructorModifiers.O,
				ConstructorDeclarator.S,
				ConstructorBody.S)
		{
		}
	}
}
