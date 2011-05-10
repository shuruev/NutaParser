using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class PreprocessingDirectives : GrammarTest
	{
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
			Check(true, SkippedCharacters.S, " #abc");
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
		public void Is_Pp_Message()
		{
			Check(true, PpMessage.S, "\r\n");
			Check(true, PpMessage.S, " xy\r\n");
			Check(true, PpMessage.S, " \r\n");
			Check(false, PpMessage.S, "xy\r\n");
			Check(false, PpMessage.S, "\n\r\n");
		}

		[TestMethod]
		public void Is_Pp_Start_Region()
		{
			Check(true, PpStartRegion.S, " # region Abc\r\n");
			Check(true, PpStartRegion.S, " #region Abc\r\n");
			Check(true, PpStartRegion.S, "# region Abc\r\n");
			Check(true, PpStartRegion.S, " # region Abc\r\n");
			Check(true, PpStartRegion.S, "#region\r\n");
			Check(true, PpStartRegion.S, "  # region Abc\r\n");
			Check(true, PpStartRegion.S, " #  region Abc\r\n");
			Check(false, PpStartRegion.S, " # regionAbc\r\n");
			Check(false, PpStartRegion.S, " # region Abc");
		}

		[TestMethod]
		public void Is_Pp_End_Region()
		{
			Check(true, PpEndRegion.S, " # endregion Abc\r\n");
			Check(true, PpEndRegion.S, " #endregion Abc\r\n");
			Check(true, PpEndRegion.S, "# endregion Abc\r\n");
			Check(true, PpEndRegion.S, " # endregion Abc\r\n");
			Check(true, PpEndRegion.S, "#endregion\r\n");
			Check(true, PpEndRegion.S, "  # endregion Abc\r\n");
			Check(true, PpEndRegion.S, " #  endregion Abc\r\n");
			Check(false, PpEndRegion.S, " # endregionAbc\r\n");
			Check(false, PpEndRegion.S, " # endregion Abc");
		}

		[TestMethod]
		public void Is_Pp_Line()
		{
			Check(true, PpLine.S, " # line default\r\n");
			Check(true, PpLine.S, " #line default\r\n");
			Check(true, PpLine.S, "# line default\r\n");
			Check(true, PpLine.S, " # line default\r\n");
			Check(true, PpLine.S, "  # line default\r\n");
			Check(true, PpLine.S, " #  line default\r\n");
			Check(true, PpLine.S, " # line default \r\n");
			Check(false, PpLine.S, " # line default");
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
			Check(true, PpPragma.S, " # pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, "  # pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, " #  pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, " # pragma warning disable 1591 \r\n");
			Check(false, PpPragma.S, " # pragma warning disable 1591");
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
		}
	}
}
