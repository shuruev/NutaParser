using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical;

namespace NutaParser.Tests.Lexical
{
	/// <summary>
	/// Provides some tests that cover untested code parts.
	/// </summary>
	[TestClass]
	public class MissedCoverage
	{
		[TestMethod]
		public void LexicalState_Uncovered()
		{
			TestHelper.Throws(() => new LexicalState(null));

			LexicalState state = new LexicalState("test");
			Assert.IsNull(state.Get("key", 0));
		}

		[TestMethod]
		public void LexicalEntry_Uncovered()
		{
			LexicalEntry entry = new LexicalEntry("key", 1, 2);
			Assert.AreEqual("key [1:2]", entry.ToString());
		}
	}
}
