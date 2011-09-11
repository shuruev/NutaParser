using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Tests
{
	[TestClass]
	public class SyntacticMachineTests
	{
		[TestMethod]
		public void SyntacticState_Uncovered()
		{
			Ensure.Throws(() => new SyntacticState(null, "data"));
			Ensure.Throws(() => new SyntacticState(new List<LexicalEntry>(), null));

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
