using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;
using Attribute = Nuta.Parser.Css.Syntactic.Attribute;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Selectors : SyntacticTest
	{
		[TestMethod]
		public void Is_Selector_List()
		{
			Check(true, SelectorList.S, ".a,#id");
			Check(true, SelectorList.S, ".a + .b, elem#id");
			Check(true, SelectorList.S, ".a + .b , elem#id");
			Check(true, SelectorList.S, ".a + .b , elem#id   ");
			Check(false, SelectorList.S, ".a + .b,, elem#id");
		}

		[TestMethod]
		public void Is_Selector()
		{
			Check(true, Selector.S, "elem");
			Check(true, Selector.S, "#id");
			Check(true, Selector.S, "elem #id");

			Check(true, Selector.S, ".a.b");
			Check(true, Selector.S, ".a+.b");
			Check(true, Selector.S, ".a>.b");
			Check(true, Selector.S, ".a .b");
			Check(true, Selector.S, ".a +.b");
			Check(true, Selector.S, ".a >.b");
			Check(true, Selector.S, ".a+ .b");
			Check(true, Selector.S, ".a> .b");
			Check(true, Selector.S, ".a + .b");
			Check(true, Selector.S, ".a > .b");

			Check(true, Selector.S, "#a + #b > #c");
			Check(false, Selector.S, "   #a + #b > #c");
			Check(true, Selector.S, "#a + #b > #c   ");
			Check(false, Selector.S, "   #a + #b > #c   ");
		}

		[TestMethod]
		public void Is_Combinator()
		{
			Check(false, Combinator.S, String.Empty);
			Check(true, Combinator.S, " ");
			Check(true, Combinator.S, "  ");
			Check(true, Combinator.S, "   ");

			Check(true, Combinator.S, "+");
			Check(true, Combinator.S, "+ ");
			Check(true, Combinator.S, " +");
			Check(true, Combinator.S, " + ");
			Check(false, Combinator.S, " ++ ");

			Check(true, Combinator.S, ">");
			Check(true, Combinator.S, "> ");
			Check(true, Combinator.S, " >");
			Check(true, Combinator.S, " > ");
			Check(false, Combinator.S, " >> ");

			Check(true, Combinator.S, "~");
			Check(true, Combinator.S, "~ ");
			Check(true, Combinator.S, " ~");
			Check(true, Combinator.S, " ~ ");
			Check(false, Combinator.S, " ~~ ");
		}

		[TestMethod]
		public void Is_Simple_Selector()
		{
			Check(true, SimpleSelector.S, "#id");
			Check(true, SimpleSelector.S, ".class");
			Check(true, SimpleSelector.S, "[att=val]");
			Check(true, SimpleSelector.S, ":pseudo");

			Check(true, SimpleSelector.S, "#id#id#id");
			Check(true, SimpleSelector.S, ".class.class.class");
			Check(true, SimpleSelector.S, "[att=val][att=val][att=val]");
			Check(true, SimpleSelector.S, ":pseudo:pseudo:pseudo");
			Check(true, SimpleSelector.S, "#id.class[att=val]:pseudo");

			Check(true, SimpleSelector.S, "elem#id");
			Check(true, SimpleSelector.S, "elem.class");
			Check(true, SimpleSelector.S, "elem[att=val]");
			Check(true, SimpleSelector.S, "elem:pseudo");

			Check(true, SimpleSelector.S, "elem#id#id#id");
			Check(true, SimpleSelector.S, "elem.class.class.class");
			Check(true, SimpleSelector.S, "elem[att=val][att=val][att=val]");
			Check(true, SimpleSelector.S, "elem:pseudo:pseudo:pseudo");
			Check(true, SimpleSelector.S, "elem#id.class[att=val]:pseudo");

			Check(false, SimpleSelector.S, "elem #id");
		}

		[TestMethod]
		public void Is_Namespace_Prefix()
		{
			Check(true, NamespacePrefix.S, "|");
			Check(false, NamespacePrefix.S, " |");
			Check(false, NamespacePrefix.S, "| ");
			Check(false, NamespacePrefix.S, "||");

			Check(false, NamespacePrefix.S, "abc");
			Check(true, NamespacePrefix.S, "abc|");
			Check(false, NamespacePrefix.S, "abc |");
			Check(false, NamespacePrefix.S, "abc| ");
			Check(true, NamespacePrefix.S, "-abc-2|");
			Check(false, NamespacePrefix.S, "-abc-2||");

			Check(false, NamespacePrefix.S, "*");
			Check(true, NamespacePrefix.S, "*|");
			Check(false, NamespacePrefix.S, "* |");
			Check(false, NamespacePrefix.S, "*| ");
			Check(false, NamespacePrefix.S, "**|");
		}

		[TestMethod]
		public void Is_Type_Selector()
		{
			Check(true, TypeSelector.S, "h1");
			Check(true, TypeSelector.S, "-h1");
			Check(true, TypeSelector.S, "-x-ns|h1");
			Check(true, TypeSelector.S, "-x-ns|-h1");
			Check(false, TypeSelector.S, "-x-ns| h1");
			Check(false, TypeSelector.S, "-x-ns|h1 ");
			Check(false, TypeSelector.S, "-x-ns|");
		}

		[TestMethod]
		public void Is_Element_Name()
		{
			Check(true, ElementName.S, "abc");
			Check(true, ElementName.S, "-abc-2");
			Check(false, ElementName.S, "-2-abc");
		}

		[TestMethod]
		public void Is_Universal()
		{
			Check(true, Universal.S, "*");
			Check(false, Universal.S, "**");
			Check(true, Universal.S, "ns|*");
			Check(true, Universal.S, "-x-ns|*");
			Check(false, Universal.S, "ns| *");
			Check(false, Universal.S, "ns *");
			Check(false, Universal.S, "ns*");
		}

		[TestMethod]
		public void Is_Class()
		{
			Check(true, Class.S, ".abc");
			Check(true, Class.S, ".-abc-2");
			Check(false, Class.S, ".");
			Check(false, Class.S, ".*");
		}

		[TestMethod]
		public void Is_Attribute()
		{
			Check(true, Attribute.S, "[att]");
			Check(true, Attribute.S, "[ att ]");
			Check(true, Attribute.S, "[ns|-att-2]");
			Check(false, Attribute.S, "[ns |-att-2]");
			Check(false, Attribute.S, "[ns| -att-2]");
			Check(true, Attribute.S, "[ ns|-att-2 ]");

			Check(true, Attribute.S, "[x|att = val]");
			Check(true, Attribute.S, "[ att = val ]");

			Check(true, Attribute.S, "[att = val]");
			Check(true, Attribute.S, "[att ~= val]");
			Check(true, Attribute.S, "[att |= val]");
			Check(true, Attribute.S, "[att ^= val]");
			Check(true, Attribute.S, "[att $= val]");
			Check(true, Attribute.S, "[att *= val]");
			Check(true, Attribute.S, "[att = \"val\"]");
			Check(true, Attribute.S, "[att = 'val']");

			Check(false, Attribute.S, "[att=]");
			Check(false, Attribute.S, "[att = 5]");
			Check(false, Attribute.S, "[att != val]");
		}

		[TestMethod]
		public void Is_Pseudo_Class()
		{
			Check(true, PseudoClass.S, ":first");
			Check(true, PseudoClass.S, ":-first");
			Check(true, PseudoClass.S, ":lang()");
			Check(true, PseudoClass.S, ":lang( )");
			Check(true, PseudoClass.S, ":lang(de)");
			Check(true, PseudoClass.S, ":lang( fr-ca)");
			Check(true, PseudoClass.S, ":lang(fr-ca )");
			Check(true, PseudoClass.S, ":lang( fr-ca )");
			Check(false, PseudoClass.S, ": first");
			Check(false, PseudoClass.S, ": lang()");
			Check(false, PseudoClass.S, ":first ");
			Check(false, PseudoClass.S, ":lang() ");
			Check(false, PseudoClass.S, ":lang ()");
			Check(false, PseudoClass.S, ":lang(15)");
		}
	}
}
