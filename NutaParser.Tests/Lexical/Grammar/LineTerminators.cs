using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class LineTerminators : GrammarTest
	{
		[TestMethod]
		public void Is_New_Line()
		{
			Check(true, NewLine.S, "\r\n");
			Check(true, NewLine.S, "\r");
			Check(true, NewLine.S, "\n");
			Check(false, NewLine.S, "\n\r");
		}
	}
}
