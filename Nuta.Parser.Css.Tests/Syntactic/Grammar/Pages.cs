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
		}

		[TestMethod]
		public void Is_Page_Additional()
		{
			Check(true, Page.S, "@page { margin: 3cm; }");
			Check(true, Page.S, "@page :left { margin-left: 4cm; margin-right: 3cm; }");
			Check(true, Page.S, "@page :right { margin-left: 3cm; margin-right: 4cm; }");
		}

		[TestMethod]
		public void Is_Pseudo_Page()
		{
			Check(true, PseudoPage.S, ":abc");
			Check(false, PseudoPage.S, ": abc");
			Check(true, PseudoPage.S, ":abc ");
			Check(true, PseudoPage.S, ":-x-abc");
		}
	}
}
