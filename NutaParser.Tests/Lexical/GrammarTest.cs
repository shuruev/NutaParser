using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical;

namespace NutaParser.Tests.Lexical
{
	/// <summary>
	/// Provides service methods for testing lexical analysis.
	/// </summary>
	public class GrammarTest
	{
		/// <summary>
		/// Checks whether specified data string can be fully parsed to the lexical item.
		/// </summary>
		public static void Check(bool expected, LexicalItem item, string data)
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
		/// Tries to parses specified data string into lexical item.
		/// </summary>
		private static bool Parse(LexicalItem item, string data)
		{
			LexicalState state = new LexicalState(data);
			bool parsed = item.Parse(state);

			if (!parsed)
				return false;

			if (!state.IsEndOfData)
				return false;

			return true;
		}
	}
}
