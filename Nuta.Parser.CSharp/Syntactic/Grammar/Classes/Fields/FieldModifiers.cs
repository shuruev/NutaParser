﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FieldModifiers : ParseMany
	{
		public static readonly FieldModifiers S = new FieldModifiers();
		public static readonly Optional O = new Optional(S);

		public FieldModifiers()
			: base(FieldModifier.S)
		{
		}
	}
}
