using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nuta.Parser.CSharp.Tests.Syntactic
{
	[TestClass]
	public class Attributes : SyntacticTest
	{
		//xxx global-attributes

		//xxx global-attribute-sections

		//xxx global-attribute-section

		//xxx global-attribute-target-specifier

		//xxx global-attribute-target

		//xxx attributes

		[TestMethod]
		public void Is_Attributes_Additional()
		{
			Check(true, CSharp.Syntactic.Attributes.S, "[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]");
		}

		//xxx attribute-sections

		//xxx attribute-section

		//xxx attribute-target-specifier

		//xxx attribute-target

		//xxx attribute-list

		//xxx attribute

		//xxx attribute-name

		//xxx attribute-arguments

		//xxx positional-argument-list

		//xxx positional-argument

		//xxx named-argument-list

		//xxx named-argument

		//xxx attribute-argument-expression
	}
}
