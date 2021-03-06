﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UsingDirectives : ParseMany
	{
		public static readonly UsingDirectives S = new UsingDirectives();
		public static readonly Optional O = new Optional(S);

		public UsingDirectives()
			: base(UsingDirective.S)
		{
		}
	}
}
