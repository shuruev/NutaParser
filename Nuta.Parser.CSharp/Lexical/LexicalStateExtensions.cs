﻿using System.Collections.Generic;
using System.Linq;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	/// <summary>
	/// Specific lexical machine methods.
	/// </summary>
	public static class LexicalStateExtensions
	{
		/// <summary>
		/// Extracts all tokens from parsed result.
		/// </summary>
		public static List<LexicalEntry> ExtractTokens(this LexicalState state)
		{
			return state
				.GetAllEntries()
				.Where(entry =>
					entry.Key == Identifier.S.Key
					|| entry.Key == Literal.S.Key
					|| entry.Key == Keyword.S.Key
					|| entry.Key == OperatorOrPunctuator.S.Key)
				.OrderBy(entry => entry.StartPosition)
				.ToList();
		}
	}
}
