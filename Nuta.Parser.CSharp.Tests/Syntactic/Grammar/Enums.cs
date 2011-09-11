using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Syntactic;

namespace Nuta.Parser.CSharp.Tests.Syntactic
{
	[TestClass]
	public class Enums : SyntacticTest
	{
		[TestMethod]
		public void Is_Enum_Declaration()
		{
			Check(true, EnumDeclaration.S, "enum Color { }");
			Check(true, EnumDeclaration.S, "enum Color { };");
			Check(true, EnumDeclaration.S, "private enum Color { Red, Blue }");
			Check(true, EnumDeclaration.S, "[SomeAttribute] public new enum Color : int { Red = 5 }");
		}

		[TestMethod]
		public void Is_Enum_Declaration_Additional()
		{
			Check(true, EnumDeclaration.S, Syntactic.EnumDeclaration1);
			Check(true, EnumDeclaration.S, Syntactic.EnumDeclaration2);
			Check(true, EnumDeclaration.S, Syntactic.EnumDeclaration3);
			Check(true, EnumDeclaration.S, Syntactic.EnumDeclaration4);
		}

		[TestMethod]
		public void Is_Enum_Base()
		{
			Check(true, EnumBase.S, ": int");
			Check(true, EnumBase.S, ": byte");
			Check(false, EnumBase.S, ": int, byte");
			Check(false, EnumBase.S, ": string");
		}

		[TestMethod]
		public void Is_Enum_Body()
		{
			Check(true, EnumBody.S, "{ }");
			Check(true, EnumBody.S, "{ Red }");
			Check(true, EnumBody.S, "{ Red, }");
			Check(true, EnumBody.S, "{ Red, Blue = 6 }");
			Check(true, EnumBody.S, "{ Red, Blue = 6, }");
			Check(false, EnumBody.S, "{ Red; Blue }");
			Check(false, EnumBody.S, "{ Red, Blue,, }");
		}

		[TestMethod]
		public void Is_Enum_Modifiers()
		{
			Check(true, EnumModifiers.S, "public private");
			Check(true, EnumModifiers.S, "public public");
		}

		[TestMethod]
		public void Is_Enum_Modifier()
		{
			Check(false, EnumModifier.S, "abstract");
			Check(false, EnumModifier.S, "extern");
			Check(true, EnumModifier.S, "internal");
			Check(false, EnumModifier.S, "internal protected");
			Check(true, EnumModifier.S, "new");
			Check(false, EnumModifier.S, "override");
			Check(true, EnumModifier.S, "private");
			Check(true, EnumModifier.S, "protected");
			Check(false, EnumModifier.S, "protected internal");
			Check(true, EnumModifier.S, "public");
			Check(false, EnumModifier.S, "readonly");
			Check(false, EnumModifier.S, "sealed");
			Check(false, EnumModifier.S, "static");
			Check(false, EnumModifier.S, "unsafe");
			Check(false, EnumModifier.S, "virtual");
			Check(false, EnumModifier.S, "volatile");
		}

		[TestMethod]
		public void Is_Enum_Member_Declarations()
		{
			Check(true, EnumMemberDeclarations.S, "Red, [SomeAttributes] Blue");
			Check(true, EnumMemberDeclarations.S, "Red = 5, [SomeAttributes] Blue = 6");
			Check(false, EnumMemberDeclarations.S, "Red, Blue,");
		}

		[TestMethod]
		public void Is_Enum_Member_Declaration()
		{
			Check(true, EnumMemberDeclaration.S, "Red");
			Check(true, EnumMemberDeclaration.S, "[SomeAttributes] Red");
			Check(true, EnumMemberDeclaration.S, "Red = 5");
			Check(true, EnumMemberDeclaration.S, "[SomeAttributes] Red = 5");
		}
	}
}
