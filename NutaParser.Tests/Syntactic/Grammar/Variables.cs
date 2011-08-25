using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Variables : GrammarTest
	{
		[TestMethod]
		public void Is_Variable_Reference()
		{
			Check(true, VariableReference.S, "5");
			Check(true, VariableReference.S, "a + b");
			Check(false, VariableReference.S, "!");
		}
	}
}
