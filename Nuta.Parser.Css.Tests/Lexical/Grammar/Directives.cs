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
		public void Is_Namespace_Symbol()
		{
			Check(true, NamespaceSymbol.S, "@namespace");
			Check(true, NamespaceSymbol.S, "@NAMESPACE");
			Check(true, NamespaceSymbol.S, "@nAmespac\\45");
			Check(false, NamespaceSymbol.S, "@ namespace");
		}
	}
}
