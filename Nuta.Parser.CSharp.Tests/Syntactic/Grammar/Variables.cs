using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Syntactic;

namespace Nuta.Parser.CSharp.Tests.Syntactic
{
	[TestClass]
	public class Variables : SyntacticTest
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
