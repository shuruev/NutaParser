﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OrderbyClause : ParseAll
	{
		public static readonly OrderbyClause S = new OrderbyClause();

		public OrderbyClause()
			: base(
				OrderbyTerminal.S,
				Orderings.S)
		{
		}
	}
}
