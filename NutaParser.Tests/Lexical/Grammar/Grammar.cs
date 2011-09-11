using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Lexical;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class Grammar : GrammarTest
	{
		[TestMethod]
		public void Is_Input()
		{
			Check(true, Input.S, "_1abc \r\n void \r\n");
			Check(true, Input.S, "\r\n\r\n");
			Check(true, Input.S, String.Empty);
			Check(false, Input.S, "   ");
		}

		[TestMethod]
		public void Is_Input_Section()
		{
			Check(true, InputSection.S, "_1abc \r\n void \r\n");
			Check(true, InputSection.S, "\r\n\r\n");
		}

		[TestMethod]
		public void Is_Input_Section_Part()
		{
			Check(true, InputSectionPart.S, "_1abc \r\n");
			Check(true, InputSectionPart.S, "\r\n");
			Check(true, InputSectionPart.S, "\n");
			Check(true, InputSectionPart.S, "#region\r\nabc\r\n#endregion\r\n");
			Check(true, InputSectionPart.S, "#pragma warning disable 1591\r\n");
			Check(false, InputSectionPart.S, "\v");
		}

		[TestMethod]
		public void Is_Input_Elements()
		{
			Check(true, InputElements.S, "\t /* comment */ _1abc void");
			Check(true, InputElements.S, "\t /* comment \r\n */ _1abc void");
			Check(false, InputElements.S, "\t /* comment */ \r\n _1abc void");
		}

		[TestMethod]
		public void Is_Input_Element()
		{
			Check(true, InputElement.S, " ");
			Check(true, InputElement.S, "\t");
			Check(true, InputElement.S, "// comment");
			Check(true, InputElement.S, "/* comment */");
			Check(true, InputElement.S, "_1abc");
			Check(true, InputElement.S, "void");

			Check(false, InputElement.S, "1abc");
			Check(false, InputElement.S, "\r\n");
		}
	}
}
