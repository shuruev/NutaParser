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
			Check(false, NamespaceName.S, "System.Collections.Dictionary<int, bool>");

			Check(true, NamespaceName.S, "Abc");
			Check(true, NamespaceName.S, "qn::Abc");
			Check(false, NamespaceName.S, "Abc<bool>");
			Check(false, NamespaceName.S, "qn::Abc<bool, byte>");

			Check(true, NamespaceName.S, "Abc.Abc");
			Check(true, NamespaceName.S, "qn::Abc.Abc");
			Check(false, NamespaceName.S, "Abc<bool>.Abc");
			Check(false, NamespaceName.S, "qn::Abc<bool, byte>.Abc");

			Check(false, NamespaceName.S, "Abc.Abc<bool>");
			Check(false, NamespaceName.S, "Abc<bool>.Abc<bool>");
			Check(false, NamespaceName.S, "qn::Abc<bool, byte>.Abc<bool>");

			Check(false, NamespaceName.S, "Abc.");
			Check(false, NamespaceName.S, "Abc.Abc.");
			Check(false, NamespaceName.S, "Abc<bool>..<bool>");
			Check(false, NamespaceName.S, "Abc<bool>.<bool>");
			Check(false, NamespaceName.S, "Abc<bool>Abc<bool>");
			Check(false, NamespaceName.S, "Abc.qn::Abc");
		}

		[TestMethod]
		public void Is_Type_Name()
		{
			Check(true, TypeName.S, "global::System.Xml.Linq");
			Check(true, TypeName.S, "System.Collections.Dictionary<int, bool>");

			Check(true, TypeName.S, "Abc");
			Check(true, TypeName.S, "qn::Abc");
			Check(true, TypeName.S, "Abc<bool>");
			Check(true, TypeName.S, "qn::Abc<bool, byte>");

			Check(true, TypeName.S, "Abc.Abc");
			Check(true, TypeName.S, "qn::Abc.Abc");
			Check(true, TypeName.S, "Abc<bool>.Abc");
			Check(true, TypeName.S, "qn::Abc<bool, byte>.Abc");

			Check(true, TypeName.S, "Abc.Abc<bool>");
			Check(true, TypeName.S, "Abc<bool>.Abc<bool>");
			Check(true, TypeName.S, "qn::Abc<bool, byte>.Abc<bool>");

			Check(false, TypeName.S, "Abc.");
			Check(false, TypeName.S, "Abc.Abc.");
			Check(false, TypeName.S, "Abc<bool>..<bool>");
			Check(false, TypeName.S, "Abc<bool>.<bool>");
			Check(false, TypeName.S, "Abc<bool>Abc<bool>");
			Check(false, TypeName.S, "Abc.qn::Abc");
		}
	}
}
