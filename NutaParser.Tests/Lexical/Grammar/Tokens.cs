using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class Tokens : GrammarTest
	{
		[TestMethod]
		public void Is_Token()
		{
			Check(true, Token.S, "_1abc");
			Check(true, Token.S, "void");
			Check(true, Token.S, "123");
			Check(true, Token.S, "123f");
			Check(true, Token.S, "'c'");
			Check(true, Token.S, "\"abc\"");
			Check(true, Token.S, ":");

			Check(false, Token.S, "1abc");
			Check(false, Token.S, "---");
			Check(false, Token.S, ":::");
		}
	}
}
