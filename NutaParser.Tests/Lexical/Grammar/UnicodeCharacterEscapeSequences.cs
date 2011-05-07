using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class UnicodeCharacterEscapeSequences : GrammarTest
	{
		[TestMethod]
		public void Is_Unicode_Escape_Sequence()
		{
			Check(true, UnicodeEscapeSequence.S, @"\u005C");
			Check(true, UnicodeEscapeSequence.S, @"\u005c");
			Check(true, UnicodeEscapeSequence.S, @"\U0000006A");
			Check(true, UnicodeEscapeSequence.S, @"\U0000006a");
			Check(false, UnicodeEscapeSequence.S, @"\U005C");
			Check(false, UnicodeEscapeSequence.S, @"\u0000006a");
		}
	}
}
