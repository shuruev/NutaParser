﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class WhereClause : ParseAll
	{
		public static readonly WhereClause S = new WhereClause();

		public WhereClause()
			: base(
				WhereTerminal.S,
				BooleanExpression.S)
		{
		}
	}
}
