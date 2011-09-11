using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Syntactic;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Delegates : GrammarTest
	{
		[TestMethod]
		public void Is_Delegate_Declaration()
		{
			Check(true, DelegateDeclaration.S, "delegate void Load();");
			Check(false, DelegateDeclaration.S, "delegate void Load()");
			Check(true, DelegateDeclaration.S, "[SomeAttribute] public new delegate void Load();");
			Check(true, DelegateDeclaration.S, "delegate void Load<in T, out T>(int index) where T : new();");
		}

		[TestMethod]
		public void Is_Delegate_Declaration_Additional()
		{
			Check(true, DelegateDeclaration.S, "delegate int D1(int i, double d);");
			Check(true, DelegateDeclaration.S, "delegate bool Predicate<T>(T value);");
		}

		[TestMethod]
		public void Is_Delegate_Modifiers()
		{
			Check(true, DelegateModifiers.S, "public private");
			Check(true, DelegateModifiers.S, "public public");
		}

		[TestMethod]
		public void Is_Delegate_Modifier()
		{
			Check(false, DelegateModifier.S, "abstract");
			Check(false, DelegateModifier.S, "extern");
			Check(true, DelegateModifier.S, "internal");
			Check(false, DelegateModifier.S, "internal protected");
			Check(true, DelegateModifier.S, "new");
			Check(false, DelegateModifier.S, "override");
			Check(true, DelegateModifier.S, "private");
			Check(true, DelegateModifier.S, "protected");
			Check(false, DelegateModifier.S, "protected internal");
			Check(true, DelegateModifier.S, "public");
			Check(false, DelegateModifier.S, "readonly");
			Check(false, DelegateModifier.S, "sealed");
			Check(false, DelegateModifier.S, "static");
			Check(false, DelegateModifier.S, "unsafe");
			Check(false, DelegateModifier.S, "virtual");
			Check(false, DelegateModifier.S, "volatile");
		}
	}
}
