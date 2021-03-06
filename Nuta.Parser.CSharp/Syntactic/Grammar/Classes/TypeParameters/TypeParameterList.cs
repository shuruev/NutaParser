﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeParameterList : ParseAll
	{
		public static readonly TypeParameterList S = new TypeParameterList();
		public static readonly Optional O = new Optional(S);

		public TypeParameterList()
			: base(
				LeftAngleBracketTerminal.S,
				TypeParameters.S,
				RightAngleBracketTerminal.S)
		{
		}
	}
}
