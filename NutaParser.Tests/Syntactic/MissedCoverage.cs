using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical;
using NutaParser.Syntactic;

namespace NutaParser.Tests.Syntactic
{
	/// <summary>
	/// Provides some tests that cover untested code parts.
	/// </summary>
	[TestClass]
	public class MissedCoverage
	{
		[TestMethod]
		public void SyntacticState_Uncovered()
		{
			TestHelper.Throws(() => new SyntacticState(null, "data"));
			TestHelper.Throws(() => new SyntacticState(new List<LexicalEntry>(), null));

			SyntacticState state = new SyntacticState(new List<LexicalEntry>(), "data");
			Assert.AreEqual(4, state.OuterLength);
		}

		[TestMethod]
		public void SyntacticEntry_Uncovered()
		{
			SyntacticEntry entry = new SyntacticEntry("key", 1, 2);
			Assert.AreEqual("key [1:2]", entry.ToString());
			Assert.AreEqual(1, entry.Length);
		}
	}
}
