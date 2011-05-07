using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class WhiteSpace : GrammarTest
	{
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
