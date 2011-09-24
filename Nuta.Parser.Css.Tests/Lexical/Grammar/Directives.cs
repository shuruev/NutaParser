using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Directives : LexicalTest
	{
		[TestMethod]
		public void Is_Import_Symbol()
		{
			Check(true, ImportSymbol.S, "@import");
			Check(true, ImportSymbol.S, "@IMPORT");
			Check(true, ImportSymbol.S, "@iMpor\\54");
			Check(false, ImportSymbol.S, "@ import");
		}

		[TestMethod]
		public void Is_Page_Symbol()
		{
			Check(true, PageSymbol.S, "@page");
			Check(true, PageSymbol.S, "@PAGE");
			Check(true, PageSymbol.S, "@pAg\\45");
			Check(false, PageSymbol.S, "@ page");
		}

		[TestMethod]
		public void Is_Media_Symbol()
		{
			Check(true, MediaSymbol.S, "@media");
			Check(true, MediaSymbol.S, "@MEDIA");
			Check(true, MediaSymbol.S, "@mEdi\\41");
			Check(false, MediaSymbol.S, "@ media");
		}

		[TestMethod]
		public void Is_Charset_Symbol()
		{
			Check(true, CharsetSymbol.S, "@charset");
			Check(true, CharsetSymbol.S, "@CHARSET");
			Check(true, CharsetSymbol.S, "@cHarse\\54");
			Check(false, CharsetSymbol.S, "@ charset");
		}

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
	}
}
