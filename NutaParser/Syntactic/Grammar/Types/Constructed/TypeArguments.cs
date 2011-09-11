﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TypeArguments : ParseMany
	{
		public static readonly TypeArguments S = new TypeArguments();

		public TypeArguments()
			: base(TypeArgument.S, CommaTerminal.S)
		{
		}
	}
}
