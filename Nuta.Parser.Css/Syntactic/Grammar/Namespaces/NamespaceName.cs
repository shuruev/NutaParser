﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class NamespaceName : ParseAll
	{
		public static readonly NamespaceName S = new NamespaceName();

		public NamespaceName()
			: base(IdentifierTerminal.S)
		{
		}
	}
}
