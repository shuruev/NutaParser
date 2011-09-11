﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AttributeList : ParseMany
	{
		public static readonly AttributeList S = new AttributeList();

		public AttributeList()
			: base(Attribute.S, CommaTerminal.S)
		{
		}
	}
}
