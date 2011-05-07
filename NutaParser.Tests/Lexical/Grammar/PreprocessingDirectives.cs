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
		public void Is_Pp_Pragma()
		{
			Check(true, PpPragma.S, " # pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, " #pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, "# pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, " # pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, "  # pragma warning disable 1591\r\n");
			Check(true, PpPragma.S, " #  pragma warning disable 1591\r\n");
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
