using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.Tests
{
	[TestClass]
	public class LexicalMachineTests
	{
		[TestMethod]
		public void LexicalState_Uncovered()
		{
			Ensure.Throws(() => new LexicalState(null));

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
