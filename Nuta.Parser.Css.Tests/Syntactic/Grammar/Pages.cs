using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Pages : SyntacticTest
	{
		[TestMethod]
		public void Is_Page()
		{
			Check(true, Page.S, "@page{}");
			Check(false, Page.S, "@ page{}");
			Check(true, Page.S, "@page { } ");
			Check(true, Page.S, "@page :abc { }");
			Check(true, Page.S, "@page :abc {;;;}");
			Check(true, Page.S, "@page :abc { ; ; ; }");
			Check(true, Page.S, "@page :abc { width: 10px; height: 20px }");
			Check(true, Page.S, "@page :abc { width: 10px; height: 20px; }");

			Check(true, Page.S, "@page LandscapeTable { }");
			Check(true, Page.S, "@page CompanyLetterHead:first { }");

			Check(true, Page.S, "@page { a: 1; b: 2; @top-left { c: 3 } @top-right { d: 4 } }");
			Check(true, Page.S, "@page { a: 1; b: 2 @top-left { c: 3 } @top-right { d: 4 } }");
			Check(false, Page.S, "@page { a: 1 b: 2; @top-left { c: 3 } @top-right { d: 4 } }");
		}

		[TestMethod]
		public void Is_Page_Additional()
		{
			Check(true, Page.S, "@page { margin: 3cm; }");
			Check(true, Page.S, "@page :left { margin-left: 4cm; margin-right: 3cm; }");
			Check(true, Page.S, "@page :right { margin-left: 3cm; margin-right: 4cm; }");

			Check(true, Page.S, "@page :first { color: green; @top-left { content: 'foo'; color: blue; } @top-right { content: 'bar'; } }");
			Check(true, Page.S, "@page { color: red; @top-center { content: 'Page ' counter(page); } }");
		}

		[TestMethod]
		public void Is_Pseudo_Page()
		{
			Check(true, PseudoPage.S, ":abc");
			Check(false, PseudoPage.S, ": abc");
			Check(false, PseudoPage.S, ":abc ");
			Check(true, PseudoPage.S, ":-x-abc");
		}

		[TestMethod]
		public void Is_Margin()
		{
			Check(true, Margin.S, "@top-left {}");
			Check(true, Margin.S, "@top-left { }");
			Check(true, Margin.S, "@top-left { }   ");
			Check(true, Margin.S, "@top-left { ;;; }");

			Check(true, Margin.S, "@top-right{color:red}");
			Check(true, Margin.S, "@top-right{color:red;}");

			Check(true, Margin.S, "@top-center { color: red }");
			Check(true, Margin.S, "@top-center { color: red; }");

			Check(true, Margin.S, "@bottom-center { width: 10px; height: 20px; }");
		}

		[TestMethod]
		public void Is_Margin_Symbol()
		{
			Check(true, MarginSymbol.S, "@top-LEFT-corner");
			Check(true, MarginSymbol.S, "@top-LEFT");
			Check(true, MarginSymbol.S, "@top-CENTER");
			Check(true, MarginSymbol.S, "@top-RIGHT");
			Check(true, MarginSymbol.S, "@top-RIGHT-corner");

			Check(true, MarginSymbol.S, "@bottom-LEFT-corner");
			Check(true, MarginSymbol.S, "@bottom-LEFT");
			Check(true, MarginSymbol.S, "@bottom-CENTER");
			Check(true, MarginSymbol.S, "@bottom-RIGHT");
			Check(true, MarginSymbol.S, "@bottom-RIGHT-corner");

			Check(true, MarginSymbol.S, "@left-TOP");
			Check(true, MarginSymbol.S, "@left-MIDDLE");
			Check(true, MarginSymbol.S, "@left-BOTTOM");

			Check(true, MarginSymbol.S, "@right-TOP");
			Check(true, MarginSymbol.S, "@right-MIDDLE");
			Check(true, MarginSymbol.S, "@right-BOTTOM");
		}
	}
}
