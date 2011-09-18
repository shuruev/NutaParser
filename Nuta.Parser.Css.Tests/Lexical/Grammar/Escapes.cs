using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Escapes : LexicalTest
	{
		[TestMethod]
		public void Is_Unicode()
		{
			Check(true, Unicode.S, "\\0");
			Check(true, Unicode.S, "\\0a");
			Check(true, Unicode.S, "\\abcdef");
			Check(true, Unicode.S, "\\0A\r\n");
			Check(true, Unicode.S, "\\AB ");
			Check(true, Unicode.S, "\\ABC\t");
			Check(true, Unicode.S, "\\ABCD\r");
			Check(true, Unicode.S, "\\ABCDE\n");
			Check(true, Unicode.S, "\\ABCDEF\f");
			Check(true, Unicode.S, "\\ABCDEF\r\n");
			Check(true, Unicode.S, "\\ABCDEF ");
			Check(false, Unicode.S, "\\0A\n\r");
			Check(false, Unicode.S, "\\0A\r\n ");
			Check(false, Unicode.S, "\\0A  ");
			Check(false, Unicode.S, "\\abcdef0");
			Check(false, Unicode.S, "\\abcdef  ");
		}

		[TestMethod]
		public void Is_Escape()
		{
			Check(true, Escape.S, "\\0");
			Check(true, Escape.S, "\\1");
			Check(true, Escape.S, "\\a");
			Check(true, Escape.S, "\\F");
			Check(true, Escape.S, "\\ABC");
			Check(true, Escape.S, "\\ABC ");
			Check(true, Escape.S, "\\z");
			Check(true, Escape.S, "\\+");
			Check(true, Escape.S, "\\*");
			Check(true, Escape.S, "\\{");
			Check(true, Escape.S, "\\}");
			Check(true, Escape.S, "\\\t");
			Check(false, Escape.S, "\\\r");
			Check(false, Escape.S, "\\\n");
			Check(false, Escape.S, "\\\f");
			Check(false, Escape.S, "\\z ");
			Check(false, Escape.S, "\\zz");
		}
	}
}
