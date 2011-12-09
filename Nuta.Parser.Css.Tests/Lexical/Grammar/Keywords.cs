using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Keywords : LexicalTest
	{
		[TestMethod]
		public void Is_Important_Symbol()
		{
			Check(true, ImportantSymbol.S, "!important");
			Check(true, ImportantSymbol.S, "!IMPORTANT");
			Check(true, ImportantSymbol.S, "!iMportan\\54");
			Check(true, ImportantSymbol.S, "! important");
			Check(true, ImportantSymbol.S, "! \t\r\n\f important");
			Check(true, ImportantSymbol.S, "!/*not*/important");
			Check(true, ImportantSymbol.S, "! /*not*/ important");
			Check(true, ImportantSymbol.S, "! /*not*/ /*very*/ important");
			Check(true, ImportantSymbol.S, "! \n\r important");
			Check(false, ImportantSymbol.S, "! \v\v important");
		}

		[TestMethod]
		public void Is_Function_Prefix()
		{
			Check(true, FunctionPrefix.S, "func(");
			Check(true, FunctionPrefix.S, "Func(");
			Check(true, FunctionPrefix.S, "some-func(");
			Check(false, FunctionPrefix.S, "func (");
			Check(false, FunctionPrefix.S, "func((");
		}

		[TestMethod]
		public void Is_Not_Prefix()
		{
			Check(true, NotPrefix.S, ":not(");
			Check(true, NotPrefix.S, ":NOT(");
			Check(true, NotPrefix.S, ":no\\54(");
			Check(false, NotPrefix.S, ": not(");
			Check(false, NotPrefix.S, ":not (");
			Check(false, NotPrefix.S, ":not((");
		}

		[TestMethod]
		public void Is_At_Keyword()
		{
			Check(true, AtKeyword.S, "@word");
			Check(true, AtKeyword.S, "@WORD");
			Check(true, AtKeyword.S, "@some-word");
			Check(false, AtKeyword.S, "@ word");
			Check(false, AtKeyword.S, "@@word");
		}
	}
}
