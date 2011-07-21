using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Basic : GrammarTest
	{
		[TestMethod]
		public void Is_Namespace_Name()
		{
			Check(true, NamespaceName.S, "global::System.Xml.Linq");
			Check(true, NamespaceName.S, "System.Collections.Dictionary<int, bool>");
		}

		[TestMethod]
		public void Is_Type_Name()
		{
			Check(true, NamespaceName.S, "global::System.Xml.Linq");
			Check(true, NamespaceName.S, "System.Collections.Dictionary<int, bool>");
		}

		[TestMethod]
		public void Is_Namespace_Or_Type_Name()
		{
			Check(true, NamespaceOrTypeName.S, "Abc");
			Check(true, NamespaceOrTypeName.S, "Abc<bool>");
			Check(true, NamespaceOrTypeName.S, "qn::Abc<bool, byte>");

			Check(true, NamespaceOrTypeName.S, "Abc.Abc");
			Check(true, NamespaceOrTypeName.S, "Abc<bool>.Abc");
			Check(true, NamespaceOrTypeName.S, "qn::Abc<bool, byte>.Abc");

			Check(true, NamespaceOrTypeName.S, "Abc.Abc<bool>");
			Check(true, NamespaceOrTypeName.S, "Abc<bool>.Abc<bool>");
			Check(true, NamespaceOrTypeName.S, "qn::Abc<bool, byte>.Abc<bool>");

			Check(false, NamespaceOrTypeName.S, "Abc.");
			Check(false, NamespaceOrTypeName.S, "Abc.Abc.");
			Check(false, NamespaceOrTypeName.S, "Abc<bool>..<bool>");
			Check(false, NamespaceOrTypeName.S, "Abc<bool>.<bool>");
			Check(false, NamespaceOrTypeName.S, "Abc<bool>Abc<bool>");
			Check(false, NamespaceOrTypeName.S, "Abc.qn::Abc");
		}
	}
}
