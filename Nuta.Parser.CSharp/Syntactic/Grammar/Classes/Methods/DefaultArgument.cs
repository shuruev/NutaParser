﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DefaultArgument : ParseAll
	{
		public static readonly DefaultArgument S = new DefaultArgument();
		public static readonly Optional O = new Optional(S);

		public DefaultArgument()
			: base(
				EqualTerminal.S,
				Expression.S)
		{
		}
	}
}
