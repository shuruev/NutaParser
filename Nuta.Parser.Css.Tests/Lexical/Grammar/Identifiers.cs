using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Identifiers : LexicalTest
	{
		[TestMethod]
		public void Is_Name_Start()
		{
			Check(true, NameStart.S, "_");
			Check(true, NameStart.S, "a");
			Check(true, NameStart.S, "A");
			Check(true, NameStart.S, "z");
			Check(true, NameStart.S, "Z");
			Check(true, NameStart.S, "ё");
			Check(true, NameStart.S, "\\&");
			Check(true, NameStart.S, "\\61");
			Check(true, NameStart.S, "\\2D");
			Check(false, NameStart.S, "-");
			Check(false, NameStart.S, "0");
			Check(false, NameStart.S, " ");
		}

		[TestMethod]
		public void Is_Name_Character()
		{
			Check(true, NameCharacter.S, "_");
			Check(true, NameCharacter.S, "-");
			Check(true, NameCharacter.S, "a");
			Check(true, NameCharacter.S, "A");
			Check(true, NameCharacter.S, "0");
			Check(true, NameCharacter.S, "Z");
			Check(true, NameCharacter.S, "ё");
			Check(true, NameCharacter.S, "\\&");
			Check(false, NameStart.S, " ");
		}

		[TestMethod]
		public void Is_Name()
		{
			Check(true, Name.S, "name");
			Check(true, Name.S, "_name");
			Check(true, Name.S, "some-name");
			Check(true, Name.S, "a_Z-0\\&ё");
			Check(false, Name.S, String.Empty);
			Check(false, Name.S, " ");
		}

		[TestMethod]
		public void Is_Identifier()
		{
			Check(true, Identifier.S, "Abc");
			Check(true, Identifier.S, "Abc-more");
			Check(true, Identifier.S, "Abc_more");
			Check(true, Identifier.S, "-Abc");
			Check(false, Identifier.S, "--Abc");
			Check(true, Identifier.S, "_Abc");
			Check(true, Identifier.S, "__Abc");
			Check(false, Identifier.S, "1Abc");
			Check(false, Identifier.S, "-1Abc");
			Check(true, Identifier.S, "_1Abc");
			Check(true, Identifier.S, "ё-152");

			Check(false, Identifier.S, "B&W?");
			Check(true, Identifier.S, "B\\&W\\?");
			Check(true, Identifier.S, "B\\26W\\3F");
			Check(true, Identifier.S, "B\\26 W\\3F");
			Check(false, Identifier.S, "B\\26  W\\3F");
		}

		[TestMethod]
		public void Is_Hash()
		{
			Check(true, Hash.S, "#red");
			Check(true, Hash.S, "#BLUE");
			Check(false, Hash.S, "# green");
		}
	}
}
