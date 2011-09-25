using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Declarations : SyntacticTest
	{
		[TestMethod]
		public void Is_Property()
		{
			Check(true, Property.S, "prop");
			Check(true, Property.S, "PROP ");
			Check(true, Property.S, "-some-other   ");
			Check(false, Property.S, "--some");
		}

		[TestMethod]
		public void Is_Priority()
		{
			Check(true, Priority.S, "!important");
			Check(true, Priority.S, "!   IMPORTANT   ");
			Check(false, Priority.S, "!important!");
		}

		[TestMethod]
		public void Is_Declaration()
		{
			Check(true, Declaration.S, "color:#red");
			Check(true, Declaration.S, "color:#red ");
			Check(true, Declaration.S, "color: #red");
			Check(true, Declaration.S, "color : #red");
			Check(false, Declaration.S, "color #red");

			Check(true, Declaration.S, "width: 15px / 10cm !important");
			Check(true, Declaration.S, "width: func(15px / 10cm) !   IMPORTANT   ");
		}
	}
}
