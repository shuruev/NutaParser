using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Lexical;

namespace Nuta.Parser.CSharp.Tests.Lexical
{
	[TestClass]
	public class Identifiers : LexicalTest
	{
		[TestMethod]
		public void Is_Identifier()
		{
			Check(true, Identifier.S, "nullnull");
			Check(true, Identifier.S, "@null");
			Check(true, Identifier.S, @"\u006Eull");
			Check(true, Identifier.S, @"@\u006Eull");
			Check(true, Identifier.S, "a_1b");
			Check(true, Identifier.S, "_1ab");

			Check(false, Identifier.S, "null");
			Check(false, Identifier.S, "1_ab");
		}

		[TestMethod]
		public void Is_Available_Identifier()
		{
			Check(true, AvailableIdentifier.S, "abcnull");
			Check(true, AvailableIdentifier.S, "nullabc");
			Check(true, AvailableIdentifier.S, "nullnull");
			Check(true, AvailableIdentifier.S, @"\u006Eull");
			Check(false, AvailableIdentifier.S, "null");
		}

		[TestMethod]
		public void Is_Identifier_Or_Keyword()
		{
			Check(true, IdentifierOrKeyword.S, @"\u00C0ab");
			Check(true, IdentifierOrKeyword.S, "a_1b");
			Check(true, IdentifierOrKeyword.S, "_1ab");
			Check(true, IdentifierOrKeyword.S, "a");
			Check(true, IdentifierOrKeyword.S, "_");
			Check(false, IdentifierOrKeyword.S, "1");
			Check(false, IdentifierOrKeyword.S, "1_ab");
		}

		[TestMethod]
		public void Is_Identifier_Start_Characters()
		{
			Check(true, IdentifierStartCharacter.S, @"\u00C0");
			Check(true, IdentifierStartCharacter.S, "a");
			Check(true, IdentifierStartCharacter.S, "_");
			Check(false, IdentifierStartCharacter.S, "1");
		}

		[TestMethod]
		public void Is_Identifier_Part_Characters()
		{
			Check(true, IdentifierPartCharacters.S, "\x00C0\x0300\xFF10\x2040\x200E");
			Check(true, IdentifierPartCharacters.S, @"\u00C0\u0300\uFF10\u2040\u200E");
			Check(true, IdentifierPartCharacters.S, "ab");
			Check(false, IdentifierPartCharacters.S, "a,b");
		}

		[TestMethod]
		public void Is_Identifier_Part_Character()
		{
			Check(true, IdentifierPartCharacter.S, "\x00C0");
			Check(true, IdentifierPartCharacter.S, @"\u00C0");
			Check(true, IdentifierPartCharacter.S, "\x0300");
			Check(true, IdentifierPartCharacter.S, @"\u0300");
			Check(true, IdentifierPartCharacter.S, "\xFF10");
			Check(true, IdentifierPartCharacter.S, @"\uFF10");
			Check(true, IdentifierPartCharacter.S, "\x2040");
			Check(true, IdentifierPartCharacter.S, @"\u2040");
			Check(true, IdentifierPartCharacter.S, "\x200E");
			Check(true, IdentifierPartCharacter.S, @"\u200E");
			Check(false, IdentifierPartCharacter.S, ",");
		}

		[TestMethod]
		public void Is_Letter_Character()
		{
			Check(true, LetterCharacter.S, "\x00C0");
			Check(true, LetterCharacter.S, @"\u00C0");
			Check(true, LetterCharacter.S, @"\U000000C0");

			Check(true, LetterCharacter.S, "\x00E0");
			Check(true, LetterCharacter.S, @"\u00E0");
			Check(true, LetterCharacter.S, @"\U000000E0");

			Check(true, LetterCharacter.S, "\x01C5");
			Check(true, LetterCharacter.S, @"\u01C5");
			Check(true, LetterCharacter.S, @"\U000001C5");

			Check(true, LetterCharacter.S, "\x02B0");
			Check(true, LetterCharacter.S, @"\u02B0");
			Check(true, LetterCharacter.S, @"\U000002B0");

			Check(true, LetterCharacter.S, "\x01BB");
			Check(true, LetterCharacter.S, @"\u01BB");
			Check(true, LetterCharacter.S, @"\U000001BB");

			Check(true, LetterCharacter.S, "\x2164");
			Check(true, LetterCharacter.S, @"\u2164");
			Check(true, LetterCharacter.S, @"\U00002164");

			Check(false, LetterCharacter.S, "\x0030");
			Check(false, LetterCharacter.S, @"\u0030");
			Check(false, LetterCharacter.S, @"\U00000030");
		}

		[TestMethod]
		public void Is_Combining_Character()
		{
			Check(true, CombiningCharacter.S, "\x0300");
			Check(true, CombiningCharacter.S, @"\u0300");
			Check(true, CombiningCharacter.S, @"\U00000300");

			Check(true, CombiningCharacter.S, "\x0903");
			Check(true, CombiningCharacter.S, @"\u0903");
			Check(true, CombiningCharacter.S, @"\U00000903");

			Check(false, CombiningCharacter.S, "\x0062");
			Check(false, CombiningCharacter.S, @"\u0062");
			Check(false, CombiningCharacter.S, @"\U00000062");
		}

		[TestMethod]
		public void Is_Decimal_Digit_Character()
		{
			Check(true, DecimalDigitCharacter.S, "\xFF10");
			Check(true, DecimalDigitCharacter.S, @"\uFF10");
			Check(true, DecimalDigitCharacter.S, @"\U0000FF10");

			Check(false, DecimalDigitCharacter.S, "\x0062");
			Check(false, DecimalDigitCharacter.S, @"\u0062");
			Check(false, DecimalDigitCharacter.S, @"\U00000062");
		}

		[TestMethod]
		public void Is_Connecting_Character()
		{
			Check(true, ConnectingCharacter.S, "\x2040");
			Check(true, ConnectingCharacter.S, @"\u2040");
			Check(true, ConnectingCharacter.S, @"\U00002040");

			Check(false, ConnectingCharacter.S, "\x0062");
			Check(false, ConnectingCharacter.S, @"\u0062");
			Check(false, ConnectingCharacter.S, @"\U00000062");
		}

		[TestMethod]
		public void Is_Formatting_Character()
		{
			Check(true, FormattingCharacter.S, "\x200E");
			Check(true, FormattingCharacter.S, @"\u200E");
			Check(true, FormattingCharacter.S, @"\U0000200E");

			Check(false, FormattingCharacter.S, "\x0062");
			Check(false, FormattingCharacter.S, @"\u0062");
			Check(false, FormattingCharacter.S, @"\U00000062");
		}
	}
}
