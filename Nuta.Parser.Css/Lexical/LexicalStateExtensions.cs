﻿using System.Collections.Generic;
using System.Linq;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	/// <summary>
	/// Specific lexical machine methods.
	/// </summary>
	public static class LexicalStateExtensions
	{
		private static readonly HashSet<string> s_toExtract;

		static LexicalStateExtensions()
		{
			List<LexicalItem> toExtract = new List<LexicalItem>();

			toExtract.AddRange(new LexicalItem[]
			{
				Whitespace.S,
				Comment.S,
				CommentDelimiterOpen.S,
				CommentDelimiterClose.S,
				FunctionPrefix.S,
				IncludesOperatorTerminal.S,
				DashmatchOperatorTerminal.S
			});

			toExtract.Add(Punctuator.S);

			toExtract.AddRange(new LexicalItem[]
			{
				UriLiteral.S,
				StringLiteral.S,
				Size.S,
				Length.S,
				Angle.S,
				Time.S,
				Freq.S,
				Dimension.S,
				Percentage.S,
				Number.S,
				Hash.S,
				Identifier.S
			});

			toExtract.AddRange(new LexicalItem[]
			{
				ImportSymbol.S,
				PageSymbol.S,
				MediaSymbol.S,
				CharsetSymbol.S,
				ImportantSymbol.S
			});

			s_toExtract = new HashSet<string>(toExtract.Select(item => item.Key));
		}

		/// <summary>
		/// Extracts all tokens from parsed result.
		/// </summary>
		public static List<LexicalEntry> ExtractTokens(this LexicalState state)
		{
			return state
				.GetAllEntries()
				.Where(entry => s_toExtract.Contains(entry.Key))
				.FilterInclusive();
		}
	}
}