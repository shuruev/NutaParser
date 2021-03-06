﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MethodHeader : ParseAll
	{
		public static readonly MethodHeader S = new MethodHeader();

		public MethodHeader()
			: base(
				Attributes.O,
				MethodModifiers.O,
				PartialTerminal.O,
				ReturnType.S,
				MemberName.S,
				TypeParameterList.O,
				LeftRoundBracketTerminal.S,
				FormalParameterList.O,
				RightRoundBracketTerminal.S,
				TypeParameterConstraintsClauses.O)
		{
		}
	}
}
