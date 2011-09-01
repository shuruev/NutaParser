using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Namespaces : GrammarTest
	{

		//xxx compilation-unit

		//xxx namespace-declaration

		//xxx qualified-identifier

		//xxx namespace-body

		//xxx extern-alias-directives

		//xxx extern-alias-directive

		//xxx using-directives

		//xxx using-directive

		//xxx using-alias-directive

		//xxx using-namespace-directive

		//xxx namespace-member-declarations

		//xxx namespace-member-declaration

		//xxx type-declaration

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
