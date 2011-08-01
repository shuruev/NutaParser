using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class OperatorsAndPunctuators : GrammarTest
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

		[TestMethod]
		public void Is_Right_Shift()
		{
			Check(true, RightShift.S, ">>");
			Check(false, RightShift.S, ">>>");
		}

		[TestMethod]
		public void Is_Right_Shift_Assignment()
		{
			Check(true, RightShiftAssignment.S, ">>=");
			Check(false, RightShiftAssignment.S, ">>>=");
		}
	}
}
