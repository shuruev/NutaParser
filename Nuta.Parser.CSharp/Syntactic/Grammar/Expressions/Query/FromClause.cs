﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FromClause : ParseAll
	{
		public static readonly FromClause S = new FromClause();

		public FromClause()
			: base(
				FromTerminal.S,
				new ParseAny(
					new ParseAll(Type.S, IdentifierTerminal.S, InTerminal.S),
					new ParseAll(IdentifierTerminal.S, InTerminal.S)),
				Expression.S)
		{
		}
	}
}
