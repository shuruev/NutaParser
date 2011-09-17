using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Comments : LexicalTest
	{
		[TestMethod]
		public void Is_Comment()
		{
			Check(true, Comment.S, "/* comment here */");
			Check(false, Comment.S, "/ * comment here */");
			Check(false, Comment.S, "/* comment here * /");

			Check(true, Comment.S, "/*** comment *** here ***/");
			Check(true, Comment.S, "/* * * comment * * * here * * */");
			Check(true, Comment.S, "/* comment\r\nhere */");
			Check(true, Comment.S, "/* comment\f\fhere */");

			Check(false, Comment.S, "/* comment /* nested */ here */");
		}
	}
}
