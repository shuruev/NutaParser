using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Namespaces : SyntacticTest
	{
		[TestMethod]
		public void Is_Namespace()
		{
			Check(true, Namespace.S, "@namespace'abc';");
			Check(true, Namespace.S, "@namespace'abc'; ");
			Check(true, Namespace.S, "@namespace'abc' ; ");
			Check(true, Namespace.S, "@namespace 'abc' ; ");

			Check(true, Namespace.S, "@namespace-ns'abc';");
			Check(true, Namespace.S, "@namespace ns 'abc';");

			Check(true, Namespace.S, "@namespace url(www.google.com);");
			Check(true, Namespace.S, "@namespace google url(www.google.com);");
			Check(false, Namespace.S, "@namespace url(www.google.com)");
			Check(false, Namespace.S, "@namespace (www.google.com)");
		}

		[TestMethod]
		public void Is_Namespace_Name()
		{
			Check(true, NamespaceName.S, "abc");
			Check(true, NamespaceName.S, "-abc-2");
			Check(false, NamespaceName.S, "--ns");
			Check(false, NamespaceName.S, "*");
		}
	}
}
