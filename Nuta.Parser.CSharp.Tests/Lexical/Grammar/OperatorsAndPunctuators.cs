using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Lexical;

namespace Nuta.Parser.CSharp.Tests.Lexical
{
	[TestClass]
	public class OperatorsAndPunctuators : LexicalTest
	{
		[TestMethod]
		public void Is_Operator_Or_Punctuator()
		{
			Check(true, OperatorOrPunctuator.S, ">");
			Check(true, OperatorOrPunctuator.S, "<");
			Check(false, OperatorOrPunctuator.S, ">>");
			Check(true, OperatorOrPunctuator.S, "<<");
			Check(false, OperatorOrPunctuator.S, ">>=");
			Check(true, OperatorOrPunctuator.S, "<<=");
			Check(false, OperatorOrPunctuator.S, ">>>=");
			Check(false, OperatorOrPunctuator.S, "=>>");
		}
	}
}
