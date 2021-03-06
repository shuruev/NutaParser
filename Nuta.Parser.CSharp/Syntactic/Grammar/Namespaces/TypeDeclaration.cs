﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeDeclaration : SyntacticItem
	{
		public static readonly TypeDeclaration S = new TypeDeclaration();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				ClassDeclaration.S,
				StructDeclaration.S,
				InterfaceDeclaration.S,
				EnumDeclaration.S,
				DelegateDeclaration.S);
		}
	}
}
