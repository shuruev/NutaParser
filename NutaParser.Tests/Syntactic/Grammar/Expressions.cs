using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Expressions : GrammarTest
	{
		[TestMethod]
		public void Is_Argument_List()
		{
			Check(true, ArgumentList.S, "abc: 5");
			Check(true, ArgumentList.S, "abc: 5, 6, d: e");
			Check(false, ArgumentList.S, "abc: 5, 6, d: e,");
		}

		[TestMethod]
		public void Is_Argument()
		{
			Check(true, Argument.S, "abc: 5");
			Check(true, Argument.S, "abc: a");
			Check(true, Argument.S, "5");
			Check(true, Argument.S, "a");
			Check(false, Argument.S, "abc a");
			Check(false, Argument.S, "abc: !");
		}

		[TestMethod]
		public void Is_Argument_Name()
		{
			Check(true, ArgumentName.S, "abc:");
			Check(false, ArgumentName.S, "abc::");
			Check(false, ArgumentName.S, "abc");
			Check(false, ArgumentName.S, "1abc:");
		}

		[TestMethod]
		public void Is_Argument_Value()
		{
			Check(true, ArgumentValue.S, "a");
			Check(true, ArgumentValue.S, "ref a");
			Check(true, ArgumentValue.S, "out a");
			Check(false, ArgumentValue.S, "!");
			Check(false, ArgumentValue.S, "in a");
		}

		[TestMethod]
		public void Is_Primary_Expression()
		{
			Check(true, PrimaryExpression.S, "Abc<T1, T2>");
			Check(true, PrimaryExpression.S, "new[] { 5, 6 }");
		}

		[TestMethod]
		public void Is_Primary_No_Array_Creation_Expression()
		{
			Check(true, PrimaryNoArrayCreationExpression.S, "\"abc\"");
			Check(true, PrimaryNoArrayCreationExpression.S, "Abc<T1, T2>");
			Check(true, PrimaryNoArrayCreationExpression.S, "((5))");
			Check(true, PrimaryNoArrayCreationExpression.S, "Abc.D<T>");
			Check(true, PrimaryNoArrayCreationExpression.S, "Abc.D(e: 5)(f: 6)");
			Check(true, PrimaryNoArrayCreationExpression.S, "Abc.D[e: 5][f: 6]");
			Check(true, PrimaryNoArrayCreationExpression.S, "this.Abc.D()");
			Check(true, PrimaryNoArrayCreationExpression.S, "this()");
			Check(true, PrimaryNoArrayCreationExpression.S, "base.Abc.D()");
			Check(true, PrimaryNoArrayCreationExpression.S, "((5++--)--)++");
			Check(true, PrimaryNoArrayCreationExpression.S, "new C(d: 5) { e = 6 }");

			// xxx
			Check(false, PrimaryNoArrayCreationExpression.S, "'abc'");
			Check(false, PrimaryNoArrayCreationExpression.S, "Abc<T>>");
			Check(false, PrimaryNoArrayCreationExpression.S, "((5)");
			Check(false, PrimaryNoArrayCreationExpression.S, "Abc.D.5");
			Check(false, PrimaryNoArrayCreationExpression.S, "Abc.D(e: )");
			Check(false, PrimaryNoArrayCreationExpression.S, "Abc.D[e: ]");
			Check(false, PrimaryNoArrayCreationExpression.S, "this.Abc.this()");
			Check(false, PrimaryNoArrayCreationExpression.S, "base.base.Abc()");
			Check(false, PrimaryNoArrayCreationExpression.S, "base()");
			Check(false, PrimaryNoArrayCreationExpression.S, "((5++--)--)+");
			Check(false, PrimaryNoArrayCreationExpression.S, "new C(d 5)");
		}

		[TestMethod]
		public void Is_Simple_Name()
		{
			Check(true, SimpleName.S, "Abc");
			Check(true, SimpleName.S, "Abc<T>");
			Check(true, SimpleName.S, "Abc<T1, T2>");
			Check(false, SimpleName.S, "1Abc");
			Check(false, SimpleName.S, "Abc<1T>");
		}

		[TestMethod]
		public void Is_Parenthesized_Expression()
		{
			Check(true, ParenthesizedExpression.S, "(5)");
			Check(true, ParenthesizedExpression.S, "((5))");
			Check(false, ParenthesizedExpression.S, "(5))");
		}

		[TestMethod]
		public void Is_Member_Access()
		{
			Check(true, MemberAccess.S, "Abc.D<T>");
			Check(true, MemberAccess.S, "Abc.D");
			Check(true, MemberAccess.S, "bool.D<T>");
			Check(true, MemberAccess.S, "bool.D");
			Check(true, MemberAccess.S, "global::Abc.D");
			Check(true, MemberAccess.S, "global::Abc<T>.D");
			Check(false, MemberAccess.S, "global::Abc.D<T>");
			Check(false, MemberAccess.S, "Abc.D.<T>");

			Check(true, MemberAccess.S, "5.CompareTo");
			Check(true, MemberAccess.S, "a.b.c");
			Check(true, MemberAccess.S, "5.A.B");
			Check(true, MemberAccess.S, "5.A");
			Check(true, MemberAccess.S, "5++--.A--++.B");
			Check(true, MemberAccess.S, "new[] { 5, 6 }.X");
			Check(false, MemberAccess.S, "5++--.A--++.B--");
		}

		[TestMethod]
		public void Is_Predefined_Type()
		{
			Check(true, PredefinedType.S, "bool");
			Check(true, PredefinedType.S, "object");
			Check(false, PredefinedType.S, "null");
		}

		[TestMethod]
		public void Is_Invocation_Expression()
		{
			Check(true, InvocationExpression.S, "Abc()");
			Check(true, InvocationExpression.S, "Abc(5)");
			Check(true, InvocationExpression.S, "Abc(5, 6, 7)");
			Check(true, InvocationExpression.S, "Abc(d: 5, 6, e: 7)");
			Check(true, InvocationExpression.S, "Abc++()");
			Check(true, InvocationExpression.S, "Abc++--()()");

			Check(false, InvocationExpression.S, "Abc(()");
			Check(false, InvocationExpression.S, "Abc++()--");
		}

		[TestMethod]
		public void Is_Element_Access()
		{
			Check(true, ElementAccess.S, "Abc[5]");
			Check(true, ElementAccess.S, "Abc[5, 6, 7]");
			Check(true, ElementAccess.S, "Abc[d: 5, 6, e: 7]");
			Check(true, ElementAccess.S, "Abc++[2]");
			Check(true, ElementAccess.S, "Abc++--[2][3]");

			Check(false, ElementAccess.S, "Abc[]");
			Check(false, ElementAccess.S, "Abc[[2]");
			Check(false, ElementAccess.S, "Abc++[2]--");
			Check(false, ElementAccess.S, "new[] { 5, 6 }[2]");
		}

		[TestMethod]
		public void Is_This_Access()
		{
			Check(true, ThisAccess.S, "this");
			Check(false, ThisAccess.S, "This");
		}

		[TestMethod]
		public void Is_Base_Access()
		{
			Check(true, BaseAccess.S, "base.A");
			Check(true, BaseAccess.S, "base[5]");
			Check(true, BaseAccess.S, "base[5, 6]");
			Check(true, BaseAccess.S, "base[a: 5]");
			Check(true, BaseAccess.S, "base[a: 5, b: 6]");

			Check(false, BaseAccess.S, "base.5");
			Check(false, BaseAccess.S, "base[]");
			Check(false, BaseAccess.S, "base[5, 6]]");
		}

		[TestMethod]
		public void Is_Post_Increment_Expression()
		{
			Check(true, PostIncrementExpression.S, "a++");
			Check(true, PostIncrementExpression.S, "a++()++");
			Check(true, PostIncrementExpression.S, "a--++()++");

			Check(false, PostIncrementExpression.S, "a+");
			Check(false, PostIncrementExpression.S, "a++()");
			Check(false, PostIncrementExpression.S, "a+()++");
			Check(false, PostIncrementExpression.S, "a++()+");
		}

		[TestMethod]
		public void Is_Post_Decrement_Expression()
		{
			Check(true, PostDecrementExpression.S, "a--");
			Check(true, PostDecrementExpression.S, "a--()--");
			Check(true, PostDecrementExpression.S, "a++--()--");

			Check(false, PostDecrementExpression.S, "a-");
			Check(false, PostDecrementExpression.S, "a--()");
			Check(false, PostDecrementExpression.S, "a-()--");
			Check(false, PostDecrementExpression.S, "a--()-");
		}

		[TestMethod]
		public void Is_Object_Creation_Expression()
		{
			Check(true, ObjectCreationExpression.S, "new A(b: 5) { c = 38 }");
			Check(true, ObjectCreationExpression.S, "new A(b: 5) { 5, 6 }");
			Check(true, ObjectCreationExpression.S, "new A(b: 5) { }");
			Check(true, ObjectCreationExpression.S, "new A(b: 5)");
			Check(true, ObjectCreationExpression.S, "new A() { c = 38 }");
			Check(true, ObjectCreationExpression.S, "new A() { }");
			Check(true, ObjectCreationExpression.S, "new A()");
			Check(true, ObjectCreationExpression.S, "new A { c = 38 }");
			Check(true, ObjectCreationExpression.S, "new A { 5, 6 }");

			Check(false, ObjectCreationExpression.S, "new A");
			Check(false, ObjectCreationExpression.S, "new A b { 5, 6 }");
		}

		[TestMethod]
		public void Is_Object_Or_Collection_Initializer()
		{
			Check(true, ObjectOrCollectionInitializer.S, "{ a = 5 }");
			Check(true, ObjectOrCollectionInitializer.S, "{ 5, 6, 7 }");
		}

		[TestMethod]
		public void Is_Object_Initializer()
		{
			Check(true, ObjectInitializer.S, "{ }");
			Check(true, ObjectInitializer.S, "{ c = this.B, c = { abc, 56 } }");
			Check(true, ObjectInitializer.S, "{ c = this.B, c = { abc, 56 }, }");
			Check(false, ObjectInitializer.S, "{ , }");
			Check(false, ObjectInitializer.S, "{ c = this.B, c = { abc, 56 },, }");
		}

		[TestMethod]
		public void Is_Member_Initializer_List()
		{
			Check(true, MemberInitializerList.S, "c = this.B, c = { abc, 56 }");
			Check(false, MemberInitializerList.S, "c = this.B, c = { abc, 56 },");
		}

		[TestMethod]
		public void Is_Member_Initializer()
		{
			Check(true, MemberInitializer.S, "c = this.B");
			Check(true, MemberInitializer.S, "c = { abc, 56 }");
			Check(false, MemberInitializer.S, "c { abc, 56 }");
		}

		[TestMethod]
		public void Is_Initializer_Value()
		{
			Check(true, InitializerValue.S, "this.A");
			Check(true, InitializerValue.S, "{ abc, 56 }");
		}

		[TestMethod]
		public void Is_Collection_Initializer()
		{
			Check(true, CollectionInitializer.S, "{ a, { c, d } }");
			Check(true, CollectionInitializer.S, "{ a, { c, d }, }");
			Check(false, CollectionInitializer.S, "{ a, { c, d }");
			Check(false, CollectionInitializer.S, "{ a, { c, d },, }");
		}

		[TestMethod]
		public void Is_Element_Initializer_List()
		{
			Check(true, ElementInitializerList.S, "a, { a, b }");
			Check(false, ElementInitializerList.S, "a, { a, b },");
		}

		[TestMethod]
		public void Is_Element_Initializer()
		{
			Check(true, ElementInitializer.S, "a");
			Check(true, ElementInitializer.S, "{ a, b }");
			//xxxCheck(true, ElementInitializer.S, "{ a = 5, b = 6 }");
			Check(false, ElementInitializer.S, "a, b");
			Check(false, ElementInitializer.S, "a = 5");
		}

		[TestMethod]
		public void Is_Expression_List()
		{
			Check(true, ExpressionList.S, "5, 6++, this.A()");
			Check(false, ExpressionList.S, "5, 6++,");
		}

		[TestMethod]
		public void Is_Array_Creation_Expression()
		{
			Check(true, ArrayCreationExpression.S, "new int[5, 6][,][,] { a, b }");
			Check(true, ArrayCreationExpression.S, "new int[][5, 6][,][,] { a, b }");
			Check(true, ArrayCreationExpression.S, "new int[5, 6][,][,]");
			Check(true, ArrayCreationExpression.S, "new int[5, 6] { a, b }");
			Check(true, ArrayCreationExpression.S, "new int[5, 6]");
			Check(false, ArrayCreationExpression.S, "new int[]");
			Check(false, ArrayCreationExpression.S, "new int[][]");

			Check(true, ArrayCreationExpression.S, "new int[] { }");
			Check(true, ArrayCreationExpression.S, "new int[] { a, b }");
			Check(false, ArrayCreationExpression.S, "new int { a, b }");

			Check(true, ArrayCreationExpression.S, "new[] { }");
			Check(true, ArrayCreationExpression.S, "new[] { a, b }");
			Check(false, ArrayCreationExpression.S, "new[][] { a, b }");
		}

		[TestMethod]
		public void Is_Delegate_Creation_Expression()
		{
			Check(true, DelegateCreationExpression.S, "new Delegate1(abc)");
			Check(true, DelegateCreationExpression.S, "new Delegate1<T>(abc)");
			Check(false, DelegateCreationExpression.S, "new Delegate1()");
			Check(false, DelegateCreationExpression.S, "new Delegate1[](abc)");
		}

		[TestMethod]
		public void Is_Anonymous_Object_Creation_Expression()
		{
			Check(true, AnonymousObjectCreationExpression.S, "new { }");
			Check(true, AnonymousObjectCreationExpression.S, "new { Abc<T1>, A = this.B }");
			Check(false, AnonymousObjectCreationExpression.S, "new { , }");
			Check(false, AnonymousObjectCreationExpression.S, "new { Abc<T1>,, }");
		}

		[TestMethod]
		public void Is_Anonymous_Object_Initializer()
		{
			Check(true, AnonymousObjectInitializer.S, "{ }");
			Check(true, AnonymousObjectInitializer.S, "{ Abc<T1>, A = this.B }");
			Check(true, AnonymousObjectInitializer.S, "{ Abc<T1>, A = this.B, }");
			Check(false, AnonymousObjectInitializer.S, "{ , }");
			Check(false, AnonymousObjectInitializer.S, "{ Abc<T1>, A = this.B,, }");
		}

		[TestMethod]
		public void Is_Member_Declarator_List()
		{
			Check(true, MemberDeclaratorList.S, "Abc<T1>, A = this.B");
			Check(false, MemberDeclaratorList.S, "Abc<T1>, A = this.B,");
		}

		[TestMethod]
		public void Is_Member_Declarator()
		{
			Check(true, MemberDeclarator.S, "Abc<T1>");
			Check(true, MemberDeclarator.S, "A.B.C");
			Check(true, MemberDeclarator.S, "A = this.B");
			Check(false, MemberDeclarator.S, "Abc<1T>");
			Check(false, MemberDeclarator.S, "A.B.char");
			Check(false, MemberDeclarator.S, "1 = this.B");
			Check(false, MemberDeclarator.S, "A == this.B");
		}
	}
}
