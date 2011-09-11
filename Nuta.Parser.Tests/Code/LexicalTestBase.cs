using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.Tests
{
	/// <summary>
	/// Provides service methods for testing lexical analysis.
	/// </summary>
	public abstract class LexicalTestBase
	{
		/// <summary>
		/// Checks whether specified data string can be fully parsed to the lexical item.
		/// </summary>
		public void Check(bool expected, LexicalItem item, string data)
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
		protected abstract bool Parse(LexicalItem item, string data);
	}
}
