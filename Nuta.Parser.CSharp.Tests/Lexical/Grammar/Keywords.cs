using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Lexical;

namespace Nuta.Parser.CSharp.Tests.Lexical
{
	[TestClass]
	public class Keywords : LexicalTest
	{
		[TestMethod]
		public void Is_Keyword()
		{
			Check(true, Keyword.S, "void");
			Check(false, Keyword.S, "voidvoid");
			Check(false, Keyword.S, "void void");
			Check(true, Keyword.S, "return");
			Check(false, Keyword.S, " ");
			Check(false, Keyword.S, "get");
			Check(false, Keyword.S, "set");
			Check(false, Keyword.S, "var");
			Check(false, Keyword.S, "async");
		}
	}
}
