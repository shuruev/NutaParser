using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Tests
{
	/// <summary>
	/// Provides service methods for testing syntactic analysis.
	/// </summary>
	public abstract class SyntacticTestBase
	{
		/// <summary>
		/// Checks whether specified data string can be fully parsed to the syntactic item.
		/// </summary>
		public void Check(bool expected, SyntacticItem item, string data)
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
		protected abstract bool Parse(SyntacticItem item, string data);
	}
}
