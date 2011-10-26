using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Grammar : SyntacticTest
	{
		[TestMethod]
		public void Is_Import()
		{
			Check(true, Import.S, "@import'abc';");
			Check(false, Import.S, "@ import'abc';");
			Check(true, Import.S, "@import 'abc';");
			Check(true, Import.S, "@import 'abc' ; ");

			Check(true, Import.S, "@import url(abc) screen, print;");
			Check(false, Import.S, "@import url(abc) screen, print;;");
		}

		[TestMethod]
		public void Is_Import_Additional()
		{
			Check(true, Import.S, "@import \"mystyle.css\";");
			Check(true, Import.S, "@import url(\"mystyle.css\");");
			Check(true, Import.S, "@import url(\"fineprint.css\") print;");
			Check(true, Import.S, "@import url(\"bluish.css\") projection, tv;");
		}

		[TestMethod]
		public void Is_Rule_Set()
		{
			Check(true, RuleSet.S, "elem {}");
			Check(true, RuleSet.S, "elem { }");
			Check(true, RuleSet.S, "elem { }   ");
			Check(true, RuleSet.S, "elem { ;;; }");

			Check(true, RuleSet.S, "elem{color:red}");
			Check(true, RuleSet.S, "elem{color:red;}");

			Check(true, RuleSet.S, "elem { color: red }");
			Check(true, RuleSet.S, "elem { color: red; }");

			Check(true, RuleSet.S, "elem#id, .class { width: 10px; height: 20px; }");
		}
	}
}
