﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DeclarationStatement : ParseAny
	{
		public static readonly DeclarationStatement S = new DeclarationStatement();

		public DeclarationStatement()
			: base(
				new ParseAll(
					LocalVariableDeclaration.S,
					SemicolonTerminal.S),
				new ParseAll(
					LocalConstantDeclaration.S,
					SemicolonTerminal.S))
		{
		}
	}
}
