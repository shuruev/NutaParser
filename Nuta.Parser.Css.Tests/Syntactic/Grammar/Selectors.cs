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
			Check(true, SelectorList.S, "   .a + .b , elem#id");
			Check(true, SelectorList.S, "   .a + .b , elem#id   ");
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
			Check(true, Selector.S, ".a~.b");
			Check(true, Selector.S, ".a .b");

			Check(true, Selector.S, ".a +.b");
			Check(true, Selector.S, ".a >.b");
			Check(true, Selector.S, ".a ~.b");
			Check(true, Selector.S, ".a+ .b");
			Check(true, Selector.S, ".a> .b");
			Check(true, Selector.S, ".a~ .b");
			Check(true, Selector.S, ".a  .b");

			Check(true, Selector.S, ".a + .b");
			Check(true, Selector.S, ".a > .b");
			Check(true, Selector.S, ".a ~ .b");
			Check(true, Selector.S, ".a   .b");

			Check(true, Selector.S, "#a + #b > #c ~ #d");
			Check(false, Selector.S, "   #a + #b > #c ~ #d");
			Check(false, Selector.S, "#a + #b > #c ~ #d   ");
			Check(false, Selector.S, "   #a + #b > #c ~ #d   ");

			Check(true, Selector.S, ".note");
			Check(true, Selector.S, "#--ident");
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

			Check(true, Combinator.S, " /*1*/   /*1*/ ");
			Check(true, Combinator.S, " /*1*/ + /*1*/ ");
			Check(true, Combinator.S, " /*1*/ > /*1*/ ");
			Check(true, Combinator.S, " /*1*/ ~ /*1*/ ");
		}

		[TestMethod]
		public void Is_Simple_Selector_Sequence()
		{
			Check(true, SimpleSelectorSequence.S, "#id");
			Check(true, SimpleSelectorSequence.S, ".class");
			Check(true, SimpleSelectorSequence.S, "[att=val]");
			Check(true, SimpleSelectorSequence.S, ":not(p)");
			Check(true, SimpleSelectorSequence.S, ":pseudo");

			Check(true, SimpleSelectorSequence.S, "#id#id#id");
			Check(true, SimpleSelectorSequence.S, ".class.class.class");
			Check(true, SimpleSelectorSequence.S, "[att=val][att=val][att=val]");
			Check(true, SimpleSelectorSequence.S, ":not(p):not(p):not(p)");
			Check(true, SimpleSelectorSequence.S, ":pseudo:pseudo:pseudo");
			Check(true, SimpleSelectorSequence.S, "#id.class[att=val]:not(p):pseudo");

			Check(true, SimpleSelectorSequence.S, "elem#id");
			Check(true, SimpleSelectorSequence.S, "elem.class");
			Check(true, SimpleSelectorSequence.S, "elem[att=val]");
			Check(true, SimpleSelectorSequence.S, "elem:not(p)");
			Check(true, SimpleSelectorSequence.S, "elem:pseudo");

			Check(true, SimpleSelectorSequence.S, "elem#id#id#id");
			Check(true, SimpleSelectorSequence.S, "elem.class.class.class");
			Check(true, SimpleSelectorSequence.S, "elem[att=val][att=val][att=val]");
			Check(true, SimpleSelectorSequence.S, "elem:not(p):not(p):not(p)");
			Check(true, SimpleSelectorSequence.S, "elem:pseudo:pseudo:pseudo");
			Check(true, SimpleSelectorSequence.S, "elem#id.class[att=val]:pseudo");

			Check(false, SimpleSelectorSequence.S, " ");
			Check(false, SimpleSelectorSequence.S, "elem #id");

			Check(true, SimpleSelectorSequence.S, "-x-ns|elem");
			Check(true, SimpleSelectorSequence.S, "-x-ns|*");
			Check(false, SimpleSelectorSequence.S, "elem*");
			Check(false, SimpleSelectorSequence.S, "**");
			Check(false, SimpleSelectorSequence.S, "elem *");
			Check(false, SimpleSelectorSequence.S, "elem elem");
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

			Check(true, Class.S, ".note");
			Check(false, Class.S, ".--ident");
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
		public void Is_Pseudo()
		{
			Check(true, Pseudo.S, ":first");
			Check(true, Pseudo.S, ":-first");
			Check(true, Pseudo.S, "::first");
			Check(true, Pseudo.S, "::-first");

			Check(false, Pseudo.S, ":lang()");
			Check(false, Pseudo.S, ":lang( )");
			Check(true, Pseudo.S, ":lang(de)");
			Check(true, Pseudo.S, ":lang(15)");
			Check(true, Pseudo.S, ":lang( fr-ca)");
			Check(true, Pseudo.S, ":lang(fr-ca )");
			Check(true, Pseudo.S, ":lang( fr-ca )");

			Check(true, Pseudo.S, ":nth-child( 3n + 1 )");
			Check(true, Pseudo.S, ":nth-child( +3n - 2 )");
			Check(true, Pseudo.S, ":nth-child( -n+ 6)");
			Check(true, Pseudo.S, ":nth-child( +6 )");

			Check(false, Pseudo.S, ": first");
			Check(false, Pseudo.S, ": lang(en)");
			Check(false, Pseudo.S, ":first ");
			Check(false, Pseudo.S, ":lang(en) ");
			Check(false, Pseudo.S, ":lang (en)");
			Check(false, Pseudo.S, ":lang(&&)");
			Check(false, Pseudo.S, ":::last");
		}

		[TestMethod]
		public void Is_Pseudo_Function()
		{
			Check(true, PseudoFunction.S, "func(an+b)");
			Check(true, PseudoFunction.S, "func(a n + b)");
			Check(true, PseudoFunction.S, "func( an+b)");
			Check(true, PseudoFunction.S, "func(an+b )");
			Check(true, PseudoFunction.S, "func( a n + b )");

			Check(false, PseudoFunction.S, " func(an+b)");
			Check(false, PseudoFunction.S, "func(an+b) ");
		}

		[TestMethod]
		public void Is_Pseudo_Expression()
		{
			Check(true, PseudoExpression.S, "an+b");
			Check(true, PseudoExpression.S, "a n + b");
			Check(false, PseudoExpression.S, " an+b");
			Check(false, PseudoExpression.S, "an+b ");

			Check(true, PseudoExpression.S, "a - b");
			Check(true, PseudoExpression.S, "a -- b");
			Check(true, PseudoExpression.S, "3cm 4mm 5");
			Check(true, PseudoExpression.S, "'3cm' \"4mm\" -new");
		}

		[TestMethod]
		public void Is_Negation()
		{
			Check(true, Negation.S, ":NOT(h1)");
			Check(false, Negation.S, ":NOT (h1)");
			Check(false, Negation.S, ": NOT(h1)");
			Check(false, Negation.S, ":NOT(h1) ");
			Check(true, Negation.S, ":NOT( h1)");
			Check(true, Negation.S, ":NOT(h1 )");
			Check(true, Negation.S, ":NOT( h1 )");

			Check(true, Negation.S, ":not(*)");
			Check(true, Negation.S, ":not(#id)");
			Check(true, Negation.S, ":not(.abc)");
			Check(true, Negation.S, ":not([att = val])");
			Check(true, Negation.S, ":not(:first)");
			Check(true, Negation.S, ":not(::first)");
		}

		[TestMethod]
		public void Is_Negation_Argument()
		{
			Check(true, NegationArgument.S, "h1");
			Check(true, NegationArgument.S, "-x-ns|h1");
			Check(true, NegationArgument.S, "*");
			Check(true, NegationArgument.S, "-x-ns|*");
			Check(true, NegationArgument.S, "#id");
			Check(false, NegationArgument.S, "-x-ns|#id");
			Check(true, NegationArgument.S, ".abc");
			Check(false, NegationArgument.S, "-x-ns|.abc");
			Check(true, NegationArgument.S, "[att = val]");
			Check(true, NegationArgument.S, "[-x-ns|att = val]");
			Check(true, NegationArgument.S, ":first");
			Check(true, NegationArgument.S, "::first");
		}
	}
}
