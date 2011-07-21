using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Namespaces : GrammarTest
	{
		[TestMethod]
		public void Is_Qualified_Alias_Member()
		{
			Check(true, QualifiedAliasMember.S, "Abc::Cde");
			Check(true, QualifiedAliasMember.S, "Abc::Cde<bool>");
			Check(true, QualifiedAliasMember.S, "Abc :: Cde < bool , byte >");
			Check(false, QualifiedAliasMember.S, "Abc:Cde");
			Check(false, QualifiedAliasMember.S, "Abc::Cde<void>");
			Check(false, QualifiedAliasMember.S, "Abc<bool>");
		}
	}
}
