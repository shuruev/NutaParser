using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class Literals : GrammarTest
	{
		[TestMethod]
		public void Is_Literal()
		{
			Check(true, Literal.S, "\"hello\"");
			Check(true, Literal.S, "'c'");
			Check(true, Literal.S, "123f");
			Check(true, Literal.S, "123");
			Check(true, Literal.S, "true");
			Check(true, Literal.S, "null");
			Check(false, Literal.S, "hello");
		}

		[TestMethod]
		public void Is_Boolean_Literal()
		{
			Check(true, BooleanLiteral.S, "true");
			Check(true, BooleanLiteral.S, "false");
			Check(false, BooleanLiteral.S, "True");
			Check(false, BooleanLiteral.S, "true false");
			Check(false, BooleanLiteral.S, " ");
		}

		[TestMethod]
		public void Is_Integer_Literal()
		{
			Check(true, IntegerLiteral.S, "1234");
			Check(true, IntegerLiteral.S, "4321lu");
			Check(false, IntegerLiteral.S, "0.");

			Check(true, IntegerLiteral.S, "0x1abc");
			Check(true, IntegerLiteral.S, "0X1ABCUL");
			Check(false, IntegerLiteral.S, "0x");
		}

		[TestMethod]
		public void Is_Decimal_Integer_Literal()
		{
			Check(true, DecimalIntegerLiteral.S, "1234");
			Check(true, DecimalIntegerLiteral.S, "4321lu");
			Check(true, DecimalIntegerLiteral.S, "4321UL");
			Check(false, DecimalIntegerLiteral.S, "0.");
			Check(false, DecimalIntegerLiteral.S, "0x1abc");
		}

		[TestMethod]
		public void Is_Decimal_Digits()
		{
			Check(true, DecimalDigits.S, "1");
			Check(true, DecimalDigits.S, "2");
			Check(false, DecimalDigits.S, "0.");
			Check(true, DecimalDigits.S, "12");
		}

		[TestMethod]
		public void Is_Decimal_Digit()
		{
			Check(true, DecimalDigit.S, "1");
			Check(true, DecimalDigit.S, "2");
			Check(false, DecimalDigit.S, "0.");
			Check(false, DecimalDigit.S, "12");
		}

		[TestMethod]
		public void Is_Integer_Type_Suffix()
		{
			Check(true, IntegerTypeSuffix.S, "U");
			Check(true, IntegerTypeSuffix.S, "lu");
			Check(true, IntegerTypeSuffix.S, "UL");
			Check(false, IntegerTypeSuffix.S, "ulu");
			Check(false, IntegerTypeSuffix.S, "LUL");
		}

		[TestMethod]
		public void Is_Hexadecimal_Integer_Literal()
		{
			Check(true, HexadecimalIntegerLiteral.S, "0x1abc");
			Check(true, HexadecimalIntegerLiteral.S, "0X1ABC");
			Check(true, HexadecimalIntegerLiteral.S, "0x1abclu");
			Check(true, HexadecimalIntegerLiteral.S, "0X1ABCUL");
			Check(false, HexadecimalIntegerLiteral.S, "0x");
			Check(false, HexadecimalIntegerLiteral.S, "1abc");
		}

		[TestMethod]
		public void Is_Hex_Digits()
		{
			Check(true, HexDigits.S, "1");
			Check(true, HexDigits.S, "A");
			Check(true, HexDigits.S, "f");
			Check(false, HexDigits.S, "0x");
			Check(true, HexDigits.S, "1a");
		}

		[TestMethod]
		public void Is_Hex_Digit()
		{
			Check(true, HexDigit.S, "1");
			Check(true, HexDigit.S, "A");
			Check(true, HexDigit.S, "f");
			Check(false, HexDigit.S, "0x");
			Check(false, HexDigit.S, "1a");
		}

		[TestMethod]
		public void Is_Real_Literal()
		{
			Check(true, RealLiteral.S, "123f");
			Check(true, RealLiteral.S, "456D");
			Check(true, RealLiteral.S, "123e2");
			Check(true, RealLiteral.S, "123e02");
			Check(true, RealLiteral.S, "456e+1f");
			Check(true, RealLiteral.S, "789e-1D");

			Check(true, RealLiteral.S, ".123");
			Check(true, RealLiteral.S, ".123f");
			Check(true, RealLiteral.S, ".456D");
			Check(true, RealLiteral.S, ".123e2");
			Check(true, RealLiteral.S, ".123e02");
			Check(true, RealLiteral.S, ".456e+1f");
			Check(true, RealLiteral.S, ".789e-1D");

			Check(true, RealLiteral.S, "01.123");
			Check(true, RealLiteral.S, "01.123f");
			Check(true, RealLiteral.S, "01.456D");
			Check(true, RealLiteral.S, "01.123e2");
			Check(true, RealLiteral.S, "01.123e02");
			Check(true, RealLiteral.S, "01.456e+1f");
			Check(true, RealLiteral.S, "01.789e-1D");

			Check(false, RealLiteral.S, ".f");
			Check(false, RealLiteral.S, "123.");
			Check(false, RealLiteral.S, "123.e2");
			Check(false, RealLiteral.S, "e02D");
		}

		[TestMethod]
		public void Is_Exponent_Part()
		{
			Check(true, ExponentPart.S, "e+123");
			Check(true, ExponentPart.S, "E-456");
			Check(true, ExponentPart.S, "e123");
			Check(true, ExponentPart.S, "E456");
			Check(false, ExponentPart.S, "e--123");
			Check(false, ExponentPart.S, "e+0x123");
		}

		[TestMethod]
		public void Is_Sign()
		{
			Check(true, Sign.S, "+");
			Check(true, Sign.S, "-");
			Check(false, Sign.S, "+-");
		}

		[TestMethod]
		public void Is_Real_Type_Suffix()
		{
			Check(true, RealTypeSuffix.S, "F");
			Check(true, RealTypeSuffix.S, "m");
			Check(false, RealTypeSuffix.S, "fm");
		}

		[TestMethod]
		public void Is_Character_Literal()
		{
			Check(true, CharacterLiteral.S, "'x'");
			Check(true, CharacterLiteral.S, @"'\a'");
			Check(true, CharacterLiteral.S, @"'\x0062'");
			Check(true, CharacterLiteral.S, @"'\u0062'");
			Check(false, CharacterLiteral.S, "'''");
			Check(false, CharacterLiteral.S, "'\\'");
		}

		[TestMethod]
		public void Is_Character()
		{
			Check(true, Character.S, "x");
			Check(true, Character.S, @"\a");
			Check(true, Character.S, @"\x0062");
			Check(true, Character.S, @"\u0062");
			Check(false, Character.S, "'");
			Check(false, Character.S, "\\");
			Check(false, Character.S, @"\x00621");
			Check(false, Character.S, @"\u00621");
		}

		[TestMethod]
		public void Is_Single_Character()
		{
			Check(true, SingleCharacter.S, "x");
			Check(true, SingleCharacter.S, "y");
			Check(false, SingleCharacter.S, "'");
			Check(false, SingleCharacter.S, "\\");
			Check(false, SingleCharacter.S, "\r");
			Check(false, SingleCharacter.S, "\n");
		}

		[TestMethod]
		public void Is_Simple_Escape_Sequence()
		{
			Check(true, SimpleEscapeSequence.S, @"\'");
			Check(true, SimpleEscapeSequence.S, @"\0");
			Check(true, SimpleEscapeSequence.S, @"\a");
			Check(false, SimpleEscapeSequence.S, @"\c");
		}

		[TestMethod]
		public void Is_Hexadecimal_Escape_Sequence()
		{
			Check(true, HexadecimalEscapeSequence.S, @"\x1");
			Check(true, HexadecimalEscapeSequence.S, @"\x12");
			Check(true, HexadecimalEscapeSequence.S, @"\x12A");
			Check(true, HexadecimalEscapeSequence.S, @"\x12ab");
			Check(false, HexadecimalEscapeSequence.S, @"\x12abc");
			Check(false, HexadecimalEscapeSequence.S, @"\\x12ab");
		}

		[TestMethod]
		public void Is_String_Literal()
		{
			Check(true, StringLiteral.S, Lexical.StringLiteral1);
			Check(true, StringLiteral.S, Lexical.StringLiteral2);
			Check(true, StringLiteral.S, Lexical.StringLiteral3);
			Check(true, StringLiteral.S, Lexical.StringLiteral4);
			Check(true, StringLiteral.S, Lexical.StringLiteral5);
			Check(true, StringLiteral.S, Lexical.StringLiteral6);
			Check(true, StringLiteral.S, Lexical.StringLiteral7);
			Check(true, StringLiteral.S, Lexical.StringLiteral8);
			Check(true, StringLiteral.S, Lexical.StringLiteral9);
			Check(true, StringLiteral.S, Lexical.StringLiteral10);

			Check(false, StringLiteral.S, Lexical.StringLiteral11);
			Check(false, StringLiteral.S, Lexical.StringLiteral12);
			Check(false, StringLiteral.S, Lexical.StringLiteral13);
		}

		[TestMethod]
		public void Is_Regular_String_Literal()
		{
			Check(true, RegularStringLiteral.S, @"""""");
			Check(true, RegularStringLiteral.S, @"""x \'\t\x0062\u0062""");
			Check(false, RegularStringLiteral.S, "abc\"");
			Check(false, RegularStringLiteral.S, "abc\\");
		}

		[TestMethod]
		public void Is_Regular_String_Literal_Characters()
		{
			Check(true, RegularStringLiteralCharacters.S, @"x \'\t\x0062\u0062");
			Check(false, RegularStringLiteralCharacters.S, "abc\"");
			Check(false, RegularStringLiteralCharacters.S, "abc\\");
		}

		[TestMethod]
		public void Is_Regular_String_Literal_Character()
		{
			Check(true, RegularStringLiteralCharacter.S, "x");
			Check(true, RegularStringLiteralCharacter.S, " ");
			Check(true, RegularStringLiteralCharacter.S, @"\'");
			Check(true, RegularStringLiteralCharacter.S, @"\t");
			Check(true, RegularStringLiteralCharacter.S, @"\x0062");
			Check(true, RegularStringLiteralCharacter.S, @"\u0062");
			Check(false, RegularStringLiteralCharacter.S, "\"");
			Check(false, RegularStringLiteralCharacter.S, "\\");
			Check(false, RegularStringLiteralCharacter.S, "\r");
			Check(false, RegularStringLiteralCharacter.S, @"\x00621");
			Check(false, RegularStringLiteralCharacter.S, @"\u00621");
		}

		[TestMethod]
		public void Is_Single_Regular_String_Literal_Character()
		{
			Check(true, SingleRegularStringLiteralCharacter.S, "x");
			Check(true, SingleRegularStringLiteralCharacter.S, "y");
			Check(false, SingleRegularStringLiteralCharacter.S, "\"");
			Check(false, SingleRegularStringLiteralCharacter.S, "\\");
			Check(false, SingleRegularStringLiteralCharacter.S, "\r");
			Check(false, SingleRegularStringLiteralCharacter.S, "\n");
		}

		[TestMethod]
		public void Is_Verbatim_String_Literal()
		{
			Check(true, VerbatimStringLiteral.S, "@\"\"");
			Check(true, VerbatimStringLiteral.S, "@\"xy\"");
			Check(true, VerbatimStringLiteral.S, "@\"x \"\" y\"");
			Check(false, VerbatimStringLiteral.S, "@ \"\"");
			Check(false, VerbatimStringLiteral.S, "@\"x \"\"\" y\"");
		}

		[TestMethod]
		public void Is_Verbatim_String_Literal_Characters()
		{
			Check(true, VerbatimStringLiteralCharacters.S, "x \"\" y");
			Check(false, VerbatimStringLiteralCharacters.S, "x \"\"\" y");
		}

		[TestMethod]
		public void Is_Verbatim_String_Literal_Character()
		{
			Check(true, VerbatimStringLiteralCharacter.S, "x");
			Check(true, VerbatimStringLiteralCharacter.S, " ");
			Check(true, VerbatimStringLiteralCharacter.S, "\"\"");
			Check(false, VerbatimStringLiteralCharacter.S, "\"");
		}

		[TestMethod]
		public void Is_Single_Verbatim_String_Literal_Character()
		{
			Check(true, SingleVerbatimStringLiteralCharacter.S, "x");
			Check(true, SingleVerbatimStringLiteralCharacter.S, " ");
			Check(false, SingleVerbatimStringLiteralCharacter.S, "\"");
			Check(false, SingleVerbatimStringLiteralCharacter.S, "xx");
		}

		[TestMethod]
		public void Is_Quote_Escape_Sequence()
		{
			Check(true, QuoteEscapeSequence.S, "\"\"");
			Check(false, NullLiteral.S, "\"");
		}

		[TestMethod]
		public void Is_Null_Literal()
		{
			Check(true, NullLiteral.S, "null");
			Check(false, NullLiteral.S, "NULL");
			Check(false, NullLiteral.S, "null null");
			Check(false, NullLiteral.S, " ");
		}
	}
}
