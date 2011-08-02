using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class Directives : GrammarTest
	{
		[TestMethod]
		public void Is_Pp_Directive()
		{
			Check(true, PpDirective.S, "#define abc // comment\r\n");
			Check(true, PpDirective.S, "#if abc\r\n1\r\n#endif\r\n");
			Check(true, PpDirective.S, "#line default\r\n");
			Check(true, PpDirective.S, "#error abc\r\n");
			Check(true, PpDirective.S, "#region abc\r\n#endregion\r\n");
			Check(true, PpDirective.S, "#pragma warning disable 1591\r\n");
		}

		[TestMethod]
		public void Is_Conditional_Symbol()
		{
			Check(true, ConditionalSymbol.S, "abc");
			Check(true, ConditionalSymbol.S, "void");
			Check(true, ConditionalSymbol.S, "true1");
			Check(true, ConditionalSymbol.S, "false2");
			Check(false, ConditionalSymbol.S, " abc");
			Check(false, ConditionalSymbol.S, "true");
			Check(false, ConditionalSymbol.S, "false");
		}

		[TestMethod]
		public void Is_Pp_Expression()
		{
			Check(true, PpExpression.S, "a || b && (c != (d == e))");
			Check(true, PpExpression.S, "a || b && c");
			Check(true, PpExpression.S, " a || b && c");
			Check(true, PpExpression.S, "a || b && c ");
			Check(true, PpExpression.S, " a || b && c ");
			Check(false, PpExpression.S, "a || b b && c");
		}

		[TestMethod]
		public void Is_Pp_Or_Expression()
		{
			Check(true, PpOrExpression.S, "a || b");
			Check(true, PpOrExpression.S, "a == b && c != d || a != b");
			Check(true, PpOrExpression.S, "a == b && c != d ||a != b");
			Check(true, PpOrExpression.S, "a == b && c != d|| a != b");
			Check(true, PpOrExpression.S, "a == b && c != d||a != b");
			Check(true, PpOrExpression.S, "a == b || c != d");
			Check(false, PpOrExpression.S, "a == b ||| c != d");
		}

		[TestMethod]
		public void Is_Pp_And_Expression()
		{
			Check(true, PpAndExpression.S, "a && b");
			Check(true, PpAndExpression.S, "a == b != false && !c != !d");
			Check(true, PpAndExpression.S, "a == b != false &&!c != !d");
			Check(true, PpAndExpression.S, "a == b != false&& !c != !d");
			Check(true, PpAndExpression.S, "a == b != false&&!c != !d");
			Check(false, PpAndExpression.S, "a == b || c != d");
		}

		[TestMethod]
		public void Is_Pp_Equality_Expression()
		{
			Check(true, PpEqualityExpression.S, "a == true ==true== true==true");
			Check(true, PpEqualityExpression.S, "b == false ==false== false==false");
			Check(true, PpEqualityExpression.S, "!a ==!! true");
			Check(false, PpEqualityExpression.S, "a = true");
			Check(false, PpEqualityExpression.S, "a = true!");
			Check(false, PpEqualityExpression.S, "a =! true");
		}

		[TestMethod]
		public void Is_Pp_Unary_Expression()
		{
			Check(true, PpUnaryExpression.S, "true");
			Check(true, PpUnaryExpression.S, "!abc");
			Check(true, PpUnaryExpression.S, "! abc");
			Check(true, PpUnaryExpression.S, "!  abc");
			Check(true, PpUnaryExpression.S, "!!  !   !!!false");
			Check(false, PpUnaryExpression.S, "true ");
			Check(false, PpUnaryExpression.S, " abc");
		}

		[TestMethod]
		public void Is_Pp_Primary_Expression()
		{
			Check(true, PpPrimaryExpression.S, "abc");
			Check(true, PpPrimaryExpression.S, "void");
			Check(true, PpPrimaryExpression.S, "true1");
			Check(true, PpPrimaryExpression.S, "false2");
			Check(true, PpPrimaryExpression.S, "true");
			Check(true, PpPrimaryExpression.S, "false");
			Check(false, PpPrimaryExpression.S, " abc");

			Check(true, PpPrimaryExpression.S, "(a == true && b != false)");
			Check(true, PpPrimaryExpression.S, "( a == true && b != false)");
			Check(true, PpPrimaryExpression.S, "(a == true && b != false )");
			Check(true, PpPrimaryExpression.S, "( a == true && b != false )");
			Check(false, PpPrimaryExpression.S, "(a b)");
			Check(false, PpPrimaryExpression.S, "(a, b)");
		}

		[TestMethod]
		public void Is_Pp_Declaration()
		{
			Check(true, PpDeclaration.S, "#define abc // comment\r\n");
			Check(true, PpDeclaration.S, " #define abc // comment\r\n");
			Check(true, PpDeclaration.S, "# define abc // comment\r\n");
			Check(true, PpDeclaration.S, " # define abc // comment\r\n");
			Check(true, PpDeclaration.S, "#undef abc\r\n");
			Check(false, PpDeclaration.S, "#define // comment\r\n");
			Check(false, PpDeclaration.S, "#undef\r\n");
			Check(false, PpDeclaration.S, "#undef abc");
		}

		[TestMethod]
		public void Is_Pp_New_Line()
		{
			Check(true, PpNewLine.S, " // comment\r\n");
			Check(true, PpNewLine.S, " // comment \r\n");
			Check(true, PpNewLine.S, " \r\n");
			Check(true, PpNewLine.S, "// comment\r\n");
			Check(true, PpNewLine.S, "\r\n");
			Check(true, PpNewLine.S, "  // comment\r\n");
			Check(true, PpNewLine.S, "  \r\n");
			Check(false, PpNewLine.S, "  abc\r\n");
		}

		[TestMethod]
		public void Is_Pp_Conditional()
		{
			Check(true, PpConditional.S, Lexical.PpConditional1);
			Check(true, PpConditional.S, Lexical.PpConditional2);
			Check(true, PpConditional.S, Lexical.PpConditional3);
			Check(true, PpConditional.S, Lexical.PpConditional4);
			Check(true, PpConditional.S, Lexical.PpConditional5);
			Check(false, PpConditional.S, Lexical.PpConditional6);
		}

		[TestMethod]
		public void Is_Pp_If_Section()
		{
			Check(true, PpIfSection.S, " # if a == b && c != d\r\nvoid\r\n");
			Check(true, PpIfSection.S, " #if a == b && c != d\r\nvoid\r\n");
			Check(true, PpIfSection.S, "# if a == b && c != d\r\nvoid\r\n");
			Check(true, PpIfSection.S, "#if a == b && c != d\r\nvoid\r\n");
			Check(true, PpIfSection.S, "  #if a == b && c != d\r\nvoid\r\n");
			Check(true, PpIfSection.S, " #  if a == b && c != d\r\nvoid\r\n");
			Check(true, PpIfSection.S, "#if a == b && c != d \r\nvoid\r\n");
			Check(true, PpIfSection.S, "#if a == b // comment\r\nvoid\r\n");
			Check(false, PpIfSection.S, " # if \r\nvoid\r\n");
			Check(false, PpIfSection.S, " # if //comment\r\nvoid\r\n");

			Check(true, PpIfSection.S, " # if a == b && c != d\r\n");
			Check(true, PpIfSection.S, " #if a == b && c != d\r\n");
			Check(true, PpIfSection.S, "# if a == b && c != d\r\n");
			Check(true, PpIfSection.S, "#if a == b && c != d\r\n");
			Check(true, PpIfSection.S, "  #if a == b && c != d\r\n");
			Check(true, PpIfSection.S, " #  if a == b && c != d\r\n");
			Check(true, PpIfSection.S, "#if a == b && c != d \r\n");
			Check(true, PpIfSection.S, "#if a == b // comment\r\n");
			Check(false, PpIfSection.S, " # if \r\n");
			Check(false, PpIfSection.S, " # if //comment\r\n");
		}

		[TestMethod]
		public void Is_Pp_Elif_Sections()
		{
			Check(true, PpElifSections.S, "#elif a == b\r\nDo1()\r\n");
			Check(true, PpElifSections.S, "#elif a == b\r\nDo1()\r\n#elif a == c\r\nDo2()\r\n");
			Check(false, PpElifSections.S, "#elif a == b\r\nDo1()\r\n#elif a == c\r\nDo2()");
			Check(false, PpElifSections.S, "#elif\r\n#elif a == c\r\nDo2()\r\n");
		}

		[TestMethod]
		public void Is_Pp_Elif_Section()
		{
			Check(true, PpElifSection.S, " # elif a == b && c != d\r\nvoid\r\n");
			Check(true, PpElifSection.S, " #elif a == b && c != d\r\nvoid\r\n");
			Check(true, PpElifSection.S, "# elif a == b && c != d\r\nvoid\r\n");
			Check(true, PpElifSection.S, "#elif a == b && c != d\r\nvoid\r\n");
			Check(true, PpElifSection.S, "  #elif a == b && c != d\r\nvoid\r\n");
			Check(true, PpElifSection.S, " #  elif a == b && c != d\r\nvoid\r\n");
			Check(true, PpElifSection.S, "#elif a == b && c != d \r\nvoid\r\n");
			Check(true, PpElifSection.S, "#elif a == b // comment\r\nvoid\r\n");
			Check(false, PpElifSection.S, " # elif \r\nvoid\r\n");
			Check(false, PpElifSection.S, " # elif //comment\r\nvoid\r\n");

			Check(true, PpElifSection.S, " # elif a == b && c != d\r\n");
			Check(true, PpElifSection.S, " #elif a == b && c != d\r\n");
			Check(true, PpElifSection.S, "# elif a == b && c != d\r\n");
			Check(true, PpElifSection.S, "#elif a == b && c != d\r\n");
			Check(true, PpElifSection.S, "  #elif a == b && c != d\r\n");
			Check(true, PpElifSection.S, " #  elif a == b && c != d\r\n");
			Check(true, PpElifSection.S, "#elif a == b && c != d \r\n");
			Check(true, PpElifSection.S, "#elif a == b // comment\r\n");
			Check(false, PpElifSection.S, " # elif \r\n");
			Check(false, PpElifSection.S, " # elif //comment\r\n");
		}

		[TestMethod]
		public void Is_Pp_Else_Section()
		{
			Check(true, PpElseSection.S, " # else // comment\r\nabc\r\nvoid\r\n");
			Check(true, PpElseSection.S, " #else // comment\r\nabc\r\nvoid\r\n");
			Check(true, PpElseSection.S, "# else // comment\r\nabc\r\nvoid\r\n");
			Check(true, PpElseSection.S, "#else // comment\r\nabc\r\nvoid\r\n");
			Check(true, PpElseSection.S, "  #else // comment\r\nabc\r\nvoid\r\n");
			Check(true, PpElseSection.S, "#  else // comment\r\nabc\r\nvoid\r\n");
			Check(true, PpElseSection.S, "#else // comment \r\nabc\r\nvoid\r\n");
			Check(true, PpElseSection.S, "#else\r\nabc\r\nvoid\r\n");
			Check(true, PpElseSection.S, "#else//comment\r\nabc\r\nvoid\r\n");

			Check(true, PpElseSection.S, " # else // comment\r\n");
			Check(true, PpElseSection.S, " #else // comment\r\n");
			Check(true, PpElseSection.S, "# else // comment\r\n");
			Check(true, PpElseSection.S, "#else // comment\r\n");
			Check(true, PpElseSection.S, "  #else // comment\r\n");
			Check(true, PpElseSection.S, "#  else // comment\r\n");
			Check(true, PpElseSection.S, "#else // comment \r\n");
			Check(true, PpElseSection.S, "#else\r\n");
			Check(true, PpElseSection.S, "#else//comment\r\n");
			Check(false, PpElseSection.S, "#else // comment");
		}

		[TestMethod]
		public void Is_Pp_Endif()
		{
			Check(true, PpEndif.S, " # endif // comment\r\n");
			Check(true, PpEndif.S, " #endif // comment\r\n");
			Check(true, PpEndif.S, "# endif // comment\r\n");
			Check(true, PpEndif.S, "#endif // comment\r\n");
			Check(true, PpEndif.S, "  #endif // comment\r\n");
			Check(true, PpEndif.S, "#  endif // comment\r\n");
			Check(true, PpEndif.S, "#endif // comment \r\n");
			Check(true, PpEndif.S, "#endif\r\n");
			Check(true, PpEndif.S, "#endif//comment\r\n");
			Check(false, PpEndif.S, "#endif // comment");
		}

		[TestMethod]
		public void Is_Conditional_Section()
		{
			Check(true, ConditionalSection.S, "_1abc \r\n void \r\n");
			Check(true, ConditionalSection.S, "\r\n\r\n");
			Check(true, ConditionalSection.S, "abc\r\n#pragma warning disable 1591\r\n");
			Check(true, ConditionalSection.S, "#region A\r\n#region B\r\nCCC\r\n#endregion\r\n#endregion\r\n");
		}

		[TestMethod]
		public void Is_Skipped_Section()
		{
			Check(true, SkippedSection.S, "abc\r\n#pragma warning disable 1591\r\n");
			Check(true, SkippedSection.S, "#region A\r\n#region B\r\nCCC\r\n#endregion\r\n#endregion\r\n");
			Check(false, SkippedSection.S, "#region A\r\n#region B\r\nCCC\r\n#endregion\r\n");
		}

		[TestMethod]
		public void Is_Skipped_Section_Part()
		{
			Check(true, SkippedSectionPart.S, "abc\r\n");
			Check(true, SkippedSectionPart.S, "#pragma warning disable 1591\r\n");
			Check(false, SkippedSectionPart.S, "#\r\n");
		}

		[TestMethod]
		public void Is_Skipped_Characters()
		{
			Check(true, SkippedCharacters.S, " abc");
			Check(true, SkippedCharacters.S, "abc");
			Check(true, SkippedCharacters.S, "a");
			Check(true, SkippedCharacters.S, " a#bc");
			Check(false, SkippedCharacters.S, " #abc");
			Check(false, SkippedCharacters.S, "#abc");
			Check(false, SkippedCharacters.S, "#");
		}

		[TestMethod]
		public void Is_Not_Number_Sign()
		{
			Check(true, NotNumberSign.S, "a");
			Check(false, NotNumberSign.S, "#");
			Check(false, NotNumberSign.S, "\n");
		}

		[TestMethod]
		public void Is_Pp_Diagnostic()
		{
			Check(true, PpDiagnostic.S, " # error abc\r\n");
			Check(true, PpDiagnostic.S, " #error abc\r\n");
			Check(true, PpDiagnostic.S, "# error abc\r\n");
			Check(true, PpDiagnostic.S, "#error abc\r\n");
			Check(true, PpDiagnostic.S, "  #error abc\r\n");
			Check(true, PpDiagnostic.S, "#  error abc\r\n");
			Check(true, PpDiagnostic.S, "#error abc \r\n");
			Check(false, PpDiagnostic.S, "#error abc");
			Check(false, PpDiagnostic.S, "#errorabc");

			Check(true, PpDiagnostic.S, " # warning abc\r\n");
			Check(true, PpDiagnostic.S, " #warning abc\r\n");
			Check(true, PpDiagnostic.S, "# warning abc\r\n");
			Check(true, PpDiagnostic.S, "#warning abc\r\n");
			Check(true, PpDiagnostic.S, "  #warning abc\r\n");
			Check(true, PpDiagnostic.S, "#  warning abc\r\n");
			Check(true, PpDiagnostic.S, "#warning abc \r\n");
			Check(false, PpDiagnostic.S, "#warning abc");
			Check(false, PpDiagnostic.S, "#warningabc");
		}

		[TestMethod]
		public void Is_Pp_Message()
		{
			Check(true, PpMessage.S, "\r\n");
			Check(true, PpMessage.S, " xy\r\n");
			Check(true, PpMessage.S, " \r\n");
			Check(false, PpMessage.S, "xy\r\n");
			Check(false, PpMessage.S, "\n\r\n");
		}

		[TestMethod]
		public void Is_Pp_Region()
		{
			Check(true, PpRegion.S, "#region\r\n#endregion\r\n");
			Check(true, PpRegion.S, "#region abc\r\n#endregion\r\n");
			Check(true, PpRegion.S, "#region abc\r\n#endregion cde\r\n");
			Check(false, PpRegion.S, "#region\r\n#endregion");
			Check(false, PpRegion.S, "#regionabc\r\n#endregion\r\n");
		}

		[TestMethod]
		public void Is_Pp_Start_Region()
		{
			Check(true, PpStartRegion.S, " # region Abc\r\n");
			Check(true, PpStartRegion.S, " #region Abc\r\n");
			Check(true, PpStartRegion.S, "# region Abc\r\n");
			Check(true, PpStartRegion.S, "#region Abc\r\n");
			Check(true, PpStartRegion.S, "#region\r\n");
			Check(true, PpStartRegion.S, "  #region Abc\r\n");
			Check(true, PpStartRegion.S, "#  region Abc\r\n");
			Check(false, PpStartRegion.S, "#regionAbc\r\n");
			Check(false, PpStartRegion.S, "#region Abc");
		}

		[TestMethod]
		public void Is_Pp_End_Region()
		{
			Check(true, PpEndRegion.S, " # endregion Abc\r\n");
			Check(true, PpEndRegion.S, " #endregion Abc\r\n");
			Check(true, PpEndRegion.S, "# endregion Abc\r\n");
			Check(true, PpEndRegion.S, "#endregion Abc\r\n");
			Check(true, PpEndRegion.S, "#endregion\r\n");
			Check(true, PpEndRegion.S, "  #endregion Abc\r\n");
			Check(true, PpEndRegion.S, "#  endregion Abc\r\n");
			Check(false, PpEndRegion.S, "#endregionAbc\r\n");
			Check(false, PpEndRegion.S, "#endregion Abc");
		}

		[TestMethod]
		public void Is_Pp_Line()
		{
			Check(true, PpLine.S, " # line default\r\n");
			Check(true, PpLine.S, " #line default\r\n");
			Check(true, PpLine.S, "# line default\r\n");
			Check(true, PpLine.S, "#line default\r\n");
			Check(true, PpLine.S, "  #line default\r\n");
			Check(true, PpLine.S, "#  line default\r\n");
			Check(true, PpLine.S, "#line default \r\n");
			Check(false, PpLine.S, "#line default");
		}

		[TestMethod]
		public void Is_Line_Indicator()
		{
			Check(true, LineIndicator.S, "123 \"abc\"");
			Check(true, LineIndicator.S, "123");
			Check(true, LineIndicator.S, "default");
			Check(true, LineIndicator.S, "hidden");
			Check(false, LineIndicator.S, "123\"abc\"");
			Check(false, LineIndicator.S, "123 ");
			Check(false, LineIndicator.S, "Default");
		}

		[TestMethod]
		public void Is_File_Name()
		{
			Check(true, FileName.S, "\"abc\"");
			Check(false, FileName.S, "\"abc");
			Check(false, FileName.S, "abc\"");
		}

		[TestMethod]
		public void Is_File_Name_Characters()
		{
			Check(true, FileNameCharacters.S, "abc");
			Check(false, FileNameCharacters.S, "ab\"c");
		}

		[TestMethod]
		public void Is_File_Name_Character()
		{
			Check(true, FileNameCharacter.S, "a");
			Check(false, FileNameCharacter.S, "\"");
			Check(false, FileNameCharacter.S, "\n");
		}

		[TestMethod]
		public void Is_Pp_Pragma()
		{
			Check(true, PpPragma.S, " # pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, " #pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, "# pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, "#pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, "  #pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, "#  pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, "#pragma warning disable 1591 \r\n");
			Check(false, PpPragma.S, "#pragma warning disable 1591");
		}

		[TestMethod]
		public void Is_Pragma_Body()
		{
			Check(true, PragmaBody.S, "warning disable 1591");
			Check(false, PragmaBody.S, "warning disable unknown");
		}

		[TestMethod]
		public void Is_Pragma_Warning_Body()
		{
			Check(true, PragmaWarningBody.S, "warning disable");
			Check(true, PragmaWarningBody.S, "warning restore 1, 2");
			Check(true, PragmaWarningBody.S, "warning  disable");
			Check(true, PragmaWarningBody.S, "warning restore  1, 2");
			Check(false, PragmaWarningBody.S, "warning disable ");
			Check(false, PragmaWarningBody.S, " warning disable");
			Check(false, PragmaWarningBody.S, "warning restore1, 2");
			Check(false, PragmaWarningBody.S, "Warning restore 1, 2");
		}

		[TestMethod]
		public void Is_Warning_Action()
		{
			Check(true, WarningAction.S, "disable");
			Check(true, WarningAction.S, "restore");
			Check(false, WarningAction.S, "enable");
			Check(false, WarningAction.S, "Disable");
		}

		[TestMethod]
		public void Is_Warning_List()
		{
			Check(true, WarningList.S, "1,2,3");
			Check(true, WarningList.S, "1, 2, 3");
			Check(true, WarningList.S, "1 ,2 ,3");
			Check(true, WarningList.S, "1 , 2 , 3");
			Check(true, WarningList.S, "123, 456");
			Check(true, WarningList.S, "123,  456");
			Check(false, WarningList.S, " 123, 456");
			Check(false, WarningList.S, "123, 456 ");
			Check(false, WarningList.S, "123 456");

			Check(false, WarningList.S, ",1");
			Check(false, WarningList.S, ", 1");
			Check(false, WarningList.S, "1,");
			Check(false, WarningList.S, "1, ");
		}
	}
}
