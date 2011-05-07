using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Tests.Lexical.Grammar
{
	[TestClass]
	public class Comments : GrammarTest
	{
		[TestMethod]
		public void Is_Comment()
		{
			Check(false, Comment.S, "x");
			Check(true, Comment.S, "//");
			Check(true, Comment.S, "// x");
			Check(false, Comment.S, "// x\n");

			Check(true, Comment.S, "/***/");
			Check(true, Comment.S, "/* xxx */");
			Check(false, Comment.S, "/***");
		}

		[TestMethod]
		public void Is_Single_Line_Comment()
		{
			Check(true, SingleLineComment.S, "//");
			Check(true, SingleLineComment.S, "// ");
			Check(true, SingleLineComment.S, "// x");
			Check(false, SingleLineComment.S, " x");
			Check(false, SingleLineComment.S, "// x\n");
		}

		[TestMethod]
		public void Is_Input_Characters()
		{
			Check(true, InputCharacters.S, "x");
			Check(true, InputCharacters.S, "xy");
			Check(false, InputCharacters.S, "\r");
			Check(false, InputCharacters.S, "\nxy");
			Check(false, InputCharacters.S, "xy\n");
			Check(false, InputCharacters.S, " \n ");
		}

		[TestMethod]
		public void Is_Input_Character()
		{
			Check(true, InputCharacter.S, "x");
			Check(true, InputCharacter.S, " ");
			Check(false, InputCharacter.S, new string((char)0x000D, 1));
			Check(false, InputCharacter.S, new string((char)0x000A, 1));
			Check(false, InputCharacter.S, new string((char)0x0085, 1));
			Check(false, InputCharacter.S, new string((char)0x2028, 1));
			Check(false, InputCharacter.S, new string((char)0x2029, 1));
			Check(false, InputCharacter.S, new string((char)0x2028, 2));
			Check(true, InputCharacter.S, new string((char)0x2027, 1));
		}

		[TestMethod]
		public void Is_New_Line_Character()
		{
			Check(false, NewLineCharacter.S, "x");
			Check(false, NewLineCharacter.S, " ");
			Check(true, NewLineCharacter.S, new string((char)0x000D, 1));
			Check(true, NewLineCharacter.S, new string((char)0x000A, 1));
			Check(true, NewLineCharacter.S, new string((char)0x0085, 1));
			Check(true, NewLineCharacter.S, new string((char)0x2028, 1));
			Check(true, NewLineCharacter.S, new string((char)0x2029, 1));
			Check(false, NewLineCharacter.S, new string((char)0x2028, 2));
			Check(false, NewLineCharacter.S, new string((char)0x2027, 1));
		}

		[TestMethod]
		public void Is_Delimited_Comment()
		{
			Check(false, DelimitedComment.S, "x");
			Check(true, DelimitedComment.S, "/* /// **/");
			Check(true, DelimitedComment.S, "/***/");
			Check(true, DelimitedComment.S, "/* xxx */");
			Check(false, DelimitedComment.S, "/***");
			Check(false, DelimitedComment.S, "/*");
			Check(false, DelimitedComment.S, "/*/");
		}

		[TestMethod]
		public void Is_Delimited_Comment_Text()
		{
			Check(true, DelimitedCommentText.S, "/");
			Check(true, DelimitedCommentText.S, "//");
			Check(true, DelimitedCommentText.S, "x");
			Check(true, DelimitedCommentText.S, "xx");
			Check(false, DelimitedCommentText.S, "*");
			Check(false, DelimitedCommentText.S, "**");
			Check(true, DelimitedCommentText.S, "//**xx");
		}

		[TestMethod]
		public void Is_Delimited_Comment_Section()
		{
			Check(true, DelimitedCommentSection.S, "/");
			Check(false, DelimitedCommentSection.S, "//");
			Check(true, DelimitedCommentSection.S, "x");
			Check(false, DelimitedCommentSection.S, "xx");
			Check(false, DelimitedCommentSection.S, "*");
			Check(false, DelimitedCommentSection.S, "**");
			Check(true, DelimitedCommentSection.S, "*x");
			Check(true, DelimitedCommentSection.S, "**x");
			Check(false, DelimitedCommentSection.S, "*xx");
			Check(false, DelimitedCommentSection.S, "**xx");
		}

		[TestMethod]
		public void Is_Asterisks()
		{
			Check(true, Asterisks.S, "*");
			Check(true, Asterisks.S, "**");
			Check(false, Asterisks.S, "x");
			Check(false, Asterisks.S, "x**");
			Check(false, Asterisks.S, "**x");
			Check(false, Asterisks.S, " * ");
		}

		[TestMethod]
		public void Is_Not_Slash_Or_Asterisk()
		{
			Check(true, NotSlashOrAsterisk.S, " ");
			Check(false, NotSlashOrAsterisk.S, "  ");
			Check(true, NotSlashOrAsterisk.S, "x");
			Check(false, NotSlashOrAsterisk.S, "xx");
			Check(false, NotSlashOrAsterisk.S, "*");
			Check(false, NotSlashOrAsterisk.S, "**");
			Check(false, NotSlashOrAsterisk.S, "/");
			Check(false, NotSlashOrAsterisk.S, "//");
		}
	}
}
