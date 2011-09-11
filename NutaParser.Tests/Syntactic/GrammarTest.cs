using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Lexical;
using Nuta.Parser.CSharp.Lexical.Grammar;
using Nuta.Parser.Lexical;
using NutaParser.Syntactic;

namespace NutaParser.Tests.Syntactic
{
	/// <summary>
	/// Provides service methods for testing syntactic analysis.
	/// </summary>
	public class GrammarTest
	{
		/// <summary>
		/// Checks whether specified data string can be fully parsed to the syntactic item.
		/// </summary>
		public static void Check(bool expected, SyntacticItem item, string data)
		{
			bool result = Parse(item, data);

			if (expected != result)
			{
				throw new AssertFailedException(
					String.Format(
						"Checking for [{0}] failed. Expected:<{1}>. Actual:<{2}>.",
						data.ToDisplay(),
						expected,
						!expected));
			}
		}

		/// <summary>
		/// Tries to parses specified data string into syntactic item.
		/// </summary>
		private static bool Parse(SyntacticItem item, string data)
		{
			data = Parser.PrepareEndOfFile(data);

			LexicalState lexicalState = new LexicalState(data);
			bool lexicalParsed = Input.S.Parse(lexicalState);

			if (!lexicalParsed)
				return false;

			if (!lexicalState.IsEndOfData)
				return false;

			SyntacticState syntacticState = new SyntacticState(
				lexicalState.ExtractTokens(),
				data);

			bool syntacticParsed = item.Parse(syntacticState);

			if (!syntacticParsed)
				return false;

			if (!syntacticState.IsEndOfData)
				return false;

			return true;
		}
	}
}
