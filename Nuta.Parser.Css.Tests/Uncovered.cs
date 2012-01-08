using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Tests
{
	[TestClass]
	public class SyntacticMachineTests
	{
		[TestMethod]
		public void SpecificAtKeyword_Uncovered()
		{
			SyntacticState state = new SyntacticState(new List<LexicalEntry>(), "empty");
			Assert.IsFalse(LeftTop.S.Parse(state));
		}
	}
}
