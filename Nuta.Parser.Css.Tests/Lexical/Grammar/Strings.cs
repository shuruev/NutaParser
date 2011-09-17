using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Strings : LexicalTest
	{
		[TestMethod]
		public void Is_String_1()
		{
			Check(true, String1.S, "\"some text\"");
			Check(true, String1.S, "\"some 'text'\"");
			Check(true, String1.S, "\"some \\\"text\\\"\"");
			Check(true, String1.S, "\"some \\22text\\22\"");
			Check(true, String1.S, "\"какой-то текст\"");
			Check(true, String1.S, "\"some\\\\text\"");
			Check(true, String1.S, "\"some\ttext\"");

			Check(true, String1.S, "\"some\\Atext\"");
			Check(true, String1.S, "\"some\\000000atext\"");
			Check(true, String1.S, "\"some\\\r\ntext\"");
			Check(true, String1.S, "\"some\\\rtext\"");
			Check(true, String1.S, "\"some\\\ntext\"");
			Check(true, String1.S, "\"some\\\ftext\"");

			Check(false, String1.S, "\"some text\\\"");
			Check(false, String1.S, "\"some\"text\"");
			Check(false, String1.S, "\"some\"\"text\"");
			Check(false, String1.S, "\"some\rtext\"");
			Check(false, String1.S, "\"some\ntext\"");
			Check(false, String1.S, "\"some\ftext\"");
			Check(false, String1.S, "\"some\r\ntext\"");
		}

		[TestMethod]
		public void Is_String_2()
		{
			Check(true, String2.S, "'some text'");
			Check(true, String2.S, "'some \"text\"'");
			Check(true, String2.S, "'some \\'text\\''");
			Check(true, String2.S, "'some \\27text\\27'");
			Check(true, String2.S, "'какой-то текст'");
			Check(true, String2.S, "'some\\\\text'");
			Check(true, String2.S, "'some\ttext'");

			Check(true, String2.S, "'some\\Atext'");
			Check(true, String2.S, "'some\\000000atext'");
			Check(true, String2.S, "'some\\\r\ntext'");
			Check(true, String2.S, "'some\\\rtext'");
			Check(true, String2.S, "'some\\\ntext'");
			Check(true, String2.S, "'some\\\ftext'");

			Check(false, String2.S, "'some text\\'");
			Check(false, String2.S, "'some'text'");
			Check(false, String2.S, "'some''text'");
			Check(false, String2.S, "'some\rtext'");
			Check(false, String2.S, "'some\ntext'");
			Check(false, String2.S, "'some\ftext'");
			Check(false, String2.S, "'some\r\ntext'");
		}

		[TestMethod]
		public void Is_String_Literal()
		{
			Check(true, StringLiteral.S, "\"some text\"");
			Check(true, StringLiteral.S, "'some text'");
		}
	}
}
