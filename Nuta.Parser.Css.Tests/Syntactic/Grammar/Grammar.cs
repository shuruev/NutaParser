using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Grammar : SyntacticTest
	{
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
