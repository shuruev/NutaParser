using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Grammar : LexicalTest
	{
		[TestMethod]
		public void Is_Whitespace_Character()
		{
			Check(true, WhitespaceCharacter.S, " ");
			Check(true, WhitespaceCharacter.S, "\t");
			Check(true, WhitespaceCharacter.S, "\r");
			Check(true, WhitespaceCharacter.S, "\n");
			Check(true, WhitespaceCharacter.S, "\f");
			Check(false, WhitespaceCharacter.S, "  ");
			Check(false, WhitespaceCharacter.S, "\v");
		}

		[TestMethod]
		public void Is_Whitespace()
		{
			Check(true, Whitespace.S, "   ");
			Check(true, Whitespace.S, "\t\t\t");
			Check(true, Whitespace.S, "\r\n\f");
			Check(true, Whitespace.S, "  \t\r\n\t  \f");
			Check(false, Whitespace.S, String.Empty);
			Check(false, Whitespace.S, "   \v");
		}

		[TestMethod]
		public void Is_New_Line()
		{
			Check(true, NewLine.S, "\r\n");
			Check(true, NewLine.S, "\r");
			Check(true, NewLine.S, "\n");
			Check(true, NewLine.S, "\f");
			Check(false, NewLine.S, "\n\r");
			Check(false, NewLine.S, "\v");
		}

		[TestMethod]
		public void Is_Hex_Digit()
		{
			Check(true, HexDigit.S, "0");
			Check(true, HexDigit.S, "a");
			Check(true, HexDigit.S, "A");
			Check(true, HexDigit.S, "F");
			Check(false, HexDigit.S, "00");
			Check(false, HexDigit.S, "g");
		}

		[TestMethod]
		public void Is_Non_Ascii()
		{
			Check(false, NonAscii.S, "0");
			Check(false, NonAscii.S, "9");
			Check(false, NonAscii.S, "a");
			Check(false, NonAscii.S, "z");
			Check(false, NonAscii.S, "A");
			Check(false, NonAscii.S, "Z");
			Check(false, NonAscii.S, new string((char)159, 1));
			Check(true, NonAscii.S, new string((char)160, 1));
			Check(true, NonAscii.S, new string((char)161, 1));
			Check(true, NonAscii.S, new string((char)254, 1));
			Check(true, NonAscii.S, new string((char)255, 1));
			Check(true, NonAscii.S, new string((char)256, 1));
			Check(true, NonAscii.S, new string((char)65534, 1));
			Check(true, NonAscii.S, new string((char)65535, 1));
		}

		[TestMethod]
		public void Is_Ascii_Digit()
		{
			Check(true, AsciiDigit.S, "0");
			Check(true, AsciiDigit.S, "1");
			Check(true, AsciiDigit.S, "9");
			Check(false, AsciiDigit.S, "00");
			Check(false, AsciiDigit.S, "a");
		}

		[TestMethod]
		public void Is_Ascii_Letter()
		{
			Check(true, AsciiLetter.S, "a");
			Check(true, AsciiLetter.S, "b");
			Check(true, AsciiLetter.S, "z");
			Check(true, AsciiLetter.S, "A");
			Check(true, AsciiLetter.S, "Y");
			Check(true, AsciiLetter.S, "Z");
			Check(false, AsciiLetter.S, "0");
			Check(false, AsciiLetter.S, "aa");
			Check(false, AsciiLetter.S, "а");
			Check(false, AsciiLetter.S, "я");
		}
	}
}
