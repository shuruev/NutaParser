﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NamespaceBody : SyntacticItem
	{
		public static readonly NamespaceBody S = new NamespaceBody();

		public override bool Parse(SyntacticState state)
		{
			return ParseAll(
				state,
				LeftCurlyBracketTerminal.S,
				ExternAliasDirectives.O,
				UsingDirectives.O,
				NamespaceMemberDeclarations.O,
				RightCurlyBracketTerminal.S);
		}
	}
}
