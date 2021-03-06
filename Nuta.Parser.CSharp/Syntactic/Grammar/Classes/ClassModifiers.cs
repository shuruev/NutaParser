﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ClassModifiers : ParseMany
	{
		public static readonly ClassModifiers S = new ClassModifiers();
		public static readonly Optional O = new Optional(S);

		public ClassModifiers()
			: base(ClassModifier.S)
		{
		}
	}
}
