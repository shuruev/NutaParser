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
	}
}
