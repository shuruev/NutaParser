using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Lexical.Grammar;

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

		[TestMethod]
		public void Is_New_Line()
		{
			Check(true, NewLine.S, "\r\n");
			Check(true, NewLine.S, "\r");
			Check(true, NewLine.S, "\n");
			Check(false, NewLine.S, "\n\r");
		}

		[TestMethod]
		public void Is_Whitespace()
		{
			Check(true, Whitespace.S, "  \t\t  \v\v  ");
			Check(false, Whitespace.S, "  \t\t \r\n \v\v  ");
		}

		[TestMethod]
		public void Is_Whitespace_Character()
		{
			Check(true, WhitespaceCharacter.S, " ");
			Check(true, WhitespaceCharacter.S, "\t");
			Check(true, WhitespaceCharacter.S, "\v");
			Check(false, WhitespaceCharacter.S, "\r");
			Check(false, WhitespaceCharacter.S, "\n");
		}
	}
}
