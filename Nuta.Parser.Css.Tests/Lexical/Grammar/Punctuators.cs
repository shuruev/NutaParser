using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Punctuators : LexicalTest
	{
		[TestMethod]
		public void Is_Plus()
		{
			Check(true, Plus.S, "+");
			Check(true, Plus.S, " +");
			Check(false, Plus.S, "++");
		}

		[TestMethod]
		public void Is_Greater()
		{
			Check(true, Greater.S, ">");
			Check(true, Greater.S, " >");
			Check(false, Greater.S, ">>");
		}

		[TestMethod]
		public void Is_Comma()
		{
			Check(true, Comma.S, ",");
			Check(true, Comma.S, " ,");
			Check(false, Comma.S, ",,");
		}

		[TestMethod]
		public void Is_Tilde()
		{
			Check(true, Tilde.S, "~");
			Check(true, Tilde.S, " ~");
			Check(false, Tilde.S, "~~");
		}
	}
}
