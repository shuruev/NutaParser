﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceMethodDeclaration : ParseAll
	{
		public static readonly InterfaceMethodDeclaration S = new InterfaceMethodDeclaration();

		public InterfaceMethodDeclaration()
			: base(
				Attributes.O,
				NewTerminal.O,
				ReturnType.S,
				IdentifierTerminal.S,
				TypeParameterList.O,
				LeftRoundBracketTerminal.S,
				FormalParameterList.O,
				RightRoundBracketTerminal.S,
				TypeParameterConstraintsClauses.O,
				SemicolonTerminal.S)
		{
		}
	}
}
