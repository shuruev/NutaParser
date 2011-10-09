﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Selectors : SyntacticTest
	{
		[TestMethod]
		public void Is_Simple_Selector()
		{
			Check(true, SimpleSelector.S, "#id");
			Check(true, SimpleSelector.S, ".class");
			Check(true, SimpleSelector.S, "[att=val]");
			Check(true, SimpleSelector.S, ":pseudo");

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
		public void Is_Class()
		{
			Check(true, Class.S, ".abc");
			Check(true, Class.S, ".-abc-2");
			Check(false, Class.S, ".");
			Check(false, Class.S, ".*");
		}

		[TestMethod]
		public void Is_Element_Name()
		{
			Check(true, ElementName.S, "abc");
			Check(true, ElementName.S, "-abc-2");
			Check(true, ElementName.S, "*");
			Check(false, ElementName.S, "**");
		}

		[TestMethod]
		public void Is_Attribute()
		{
			Check(true, Attribute.S, "[att]");
			Check(true, Attribute.S, "[ att ]");
			Check(true, Attribute.S, "[att = val]");
			Check(true, Attribute.S, "[ att = val ]");
			Check(true, Attribute.S, "[att = val]");
			Check(true, Attribute.S, "[att ~= val]");
			Check(true, Attribute.S, "[att |= val]");
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
