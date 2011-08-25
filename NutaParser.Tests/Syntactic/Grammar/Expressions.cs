﻿using System;
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
			Check(true, PrimaryNoArrayCreationExpression.S, "new Delegate1<T>(abc)");
			Check(true, PrimaryNoArrayCreationExpression.S, "new { Abc<T1>, A = this.B }");
			Check(true, PrimaryNoArrayCreationExpression.S, "typeof(X<T>)");
			Check(true, PrimaryNoArrayCreationExpression.S, "checked(a++)");
			Check(true, PrimaryNoArrayCreationExpression.S, "unchecked(a--)");
			Check(true, PrimaryNoArrayCreationExpression.S, "default(List<int>)");
			//xxxCheck(true, PrimaryNoArrayCreationExpression.S, "delegate (int a) { return 5; }");

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
			Check(false, PrimaryNoArrayCreationExpression.S, "new delegate()");
			Check(false, PrimaryNoArrayCreationExpression.S, "new { , }");
			Check(false, PrimaryNoArrayCreationExpression.S, "typeof(X<void>)");
			Check(false, PrimaryNoArrayCreationExpression.S, "checked((a++)");
			Check(false, PrimaryNoArrayCreationExpression.S, "unchecked((a--)");
			Check(false, PrimaryNoArrayCreationExpression.S, "default((List<int>)");
			Check(false, PrimaryNoArrayCreationExpression.S, "delegate (int a) { ;; }");
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
			Check(true, ElementInitializer.S, "{ a = 5, b = 6 }");
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

		[TestMethod]
		public void Is_Typeof_Expression()
		{
			Check(true, TypeofExpression.S, "typeof(int)");
			Check(true, TypeofExpression.S, "typeof(Abc)");
			Check(true, TypeofExpression.S, "typeof(global::Abc)");
			Check(true, TypeofExpression.S, "typeof(Abc<>)");
			Check(true, TypeofExpression.S, "typeof(Abc<T>)");
			Check(true, TypeofExpression.S, "typeof(Abc<,>)");
			Check(true, TypeofExpression.S, "typeof(Abc<T1, T2>)");
			Check(true, TypeofExpression.S, "typeof(void)");

			Check(false, TypeofExpression.S, "typeof()");
			Check(false, TypeofExpression.S, "typeof(null)");
			Check(false, TypeofExpression.S, "typeof(5)");
			Check(false, TypeofExpression.S, "typeof(global::void)");

			Check(true, TypeofExpression.S, "typeof(int)");
			Check(true, TypeofExpression.S, "typeof(System.Int32)");
			Check(true, TypeofExpression.S, "typeof(string)");
			Check(true, TypeofExpression.S, "typeof(double[])");
			Check(true, TypeofExpression.S, "typeof(void)");
			Check(true, TypeofExpression.S, "typeof(T)");
			Check(true, TypeofExpression.S, "typeof(X<T>)");
			Check(true, TypeofExpression.S, "typeof(X<X<T>>)");
			Check(true, TypeofExpression.S, "typeof(X<>)");
		}

		[TestMethod]
		public void Is_Unbound_Type_Name()
		{
			Check(true, UnboundTypeName.S, "Abc");
			Check(true, UnboundTypeName.S, "Abc<>");
			Check(true, UnboundTypeName.S, "Abc<,,>");
			Check(true, UnboundTypeName.S, "global::Abc<,,>");
			Check(true, UnboundTypeName.S, "global::Abc");
			Check(true, UnboundTypeName.S, "global::Abc<,,>.D<,>");
			Check(true, UnboundTypeName.S, "Abc<,,>.D.E<>");
			Check(true, UnboundTypeName.S, "global::Abc<,,>.D.E<>.F<,,>.G<,,,>");

			Check(false, UnboundTypeName.S, "1Abc<>");
			Check(false, UnboundTypeName.S, "<>");
			Check(false, UnboundTypeName.S, "Abc::<,,>");
			Check(false, UnboundTypeName.S, "Abc.D::E");
		}

		[TestMethod]
		public void Is_Generic_Dimension_Specifier()
		{
			Check(true, GenericDimensionSpecifier.S, "<,,>");
			Check(true, GenericDimensionSpecifier.S, "<>");
			Check(false, GenericDimensionSpecifier.S, "<.,>");
		}

		[TestMethod]
		public void Is_Commas()
		{
			Check(true, Commas.S, ",");
			Check(true, Commas.S, ",,");
			Check(true, Commas.S, ",, ,");
			Check(false, Commas.S, String.Empty);
			Check(false, Commas.S, " ");
			Check(false, Commas.S, ".,");
		}

		[TestMethod]
		public void Is_Checked_Expression()
		{
			Check(true, CheckedExpression.S, "checked(5)");
			Check(true, CheckedExpression.S, "checked(6++)");
			Check(true, CheckedExpression.S, "checked(this.A())");
			Check(false, CheckedExpression.S, "checked((5)");
			Check(false, CheckedExpression.S, "checked 5");
		}

		[TestMethod]
		public void Is_Unchecked_Expression()
		{
			Check(true, UncheckedExpression.S, "unchecked(5)");
			Check(true, UncheckedExpression.S, "unchecked(6++)");
			Check(true, UncheckedExpression.S, "unchecked(this.A())");
			Check(false, UncheckedExpression.S, "unchecked((5)");
			Check(false, UncheckedExpression.S, "unchecked 5");
		}

		[TestMethod]
		public void Is_Default_Value_Expression()
		{
			Check(true, DefaultValueExpression.S, "default(int)");
			Check(true, DefaultValueExpression.S, "default(Abc)");
			Check(true, DefaultValueExpression.S, "default(global::Abc)");
			Check(false, DefaultValueExpression.S, "default((int)");
			Check(false, DefaultValueExpression.S, "default int");
		}

		[TestMethod]
		public void Is_Unary_Expression()
		{
			Check(true, UnaryExpression.S, "--++-+-+this.A()++");
			Check(true, UnaryExpression.S, "!!~~!~!~this.A()--");
			Check(true, UnaryExpression.S, "(int)++(a.b)--");
			Check(true, UnaryExpression.S, "a.b--++");
			Check(false, UnaryExpression.S, "::a.b");
			Check(false, UnaryExpression.S, "(a, b)");
		}

		[TestMethod]
		public void Is_Pre_Increment_Expression()
		{
			Check(true, PreIncrementExpression.S, "++a");
			Check(true, PreIncrementExpression.S, "++(a.b)");
			Check(true, PreIncrementExpression.S, "++(int)a--");
			Check(true, PreIncrementExpression.S, "+++a--");
			Check(true, PreIncrementExpression.S, "++++a--");

			Check(false, PreIncrementExpression.S, "(int)++a");
			Check(false, PreIncrementExpression.S, "++(int)");
		}

		[TestMethod]
		public void Is_Pre_Decrement_Expression()
		{
			Check(true, PreDecrementExpression.S, "--a");
			Check(true, PreDecrementExpression.S, "--(a.b)");
			Check(true, PreDecrementExpression.S, "--(int)a++");
			Check(true, PreDecrementExpression.S, "---a++");
			Check(true, PreDecrementExpression.S, "----a++");

			Check(false, PreDecrementExpression.S, "(int)--a");
			Check(false, PreDecrementExpression.S, "--(int)");
		}

		[TestMethod]
		public void Is_Cast_Expression()
		{
			Check(true, CastExpression.S, "(int)a++");
			Check(true, CastExpression.S, "(T)this.A()++");
			Check(true, CastExpression.S, "(List<int>)++5");
			Check(false, CastExpression.S, "(a++)int");
			Check(false, CastExpression.S, "(<int>)++5");
		}

		[TestMethod]
		public void Is_Multiplicative_Expression()
		{
			Check(true, MultiplicativeExpression.S, "5");
			Check(true, MultiplicativeExpression.S, "5 * 6");
			Check(true, MultiplicativeExpression.S, "5 * 6 / A.B / c % d");
			Check(false, MultiplicativeExpression.S, "5 ** 6");
			Check(false, MultiplicativeExpression.S, "5 * 6 /");
		}

		[TestMethod]
		public void Is_Additive_Expression()
		{
			Check(true, AdditiveExpression.S, "5");
			Check(true, AdditiveExpression.S, "5 + 6");
			Check(true, AdditiveExpression.S, "5 + 6 - A.B - c");
			Check(true, AdditiveExpression.S, "1 * 2 + 3 / 4 - 5 % 6");
			Check(true, AdditiveExpression.S, "5 + + 6");
			Check(false, AdditiveExpression.S, "5 ++ 6");
			Check(false, AdditiveExpression.S, "5 + 6 -");
		}

		[TestMethod]
		public void Is_Shift_Expression()
		{
			Check(true, ShiftExpression.S, "5");
			Check(true, ShiftExpression.S, "5 >> 6");
			Check(true, ShiftExpression.S, "5 >> 6 << A.B << c");
			Check(true, ShiftExpression.S, "1 * 2 + 3 << 4 / (5 - 5 % 6) << 7");

			Check(false, ShiftExpression.S, "5 >");
			Check(false, ShiftExpression.S, "5 ><");
			Check(false, ShiftExpression.S, "5 >>");
			Check(false, ShiftExpression.S, "5 > > 6");
			Check(false, ShiftExpression.S, "5 >>> 6");
			Check(false, ShiftExpression.S, "5 >> 6 <<");
		}

		[TestMethod]
		public void Is_Relational_Expression()
		{
			Check(true, RelationalExpression.S, "a");
			Check(true, RelationalExpression.S, "(a < b) > c");
			Check(true, RelationalExpression.S, "a <= b >= c");
			Check(true, RelationalExpression.S, "a is bool?[] as List<int?>");
			Check(true, RelationalExpression.S, "(a < b) > c <= d >= e is g as int > c <= d >= e is g");
			Check(true, RelationalExpression.S, "1 * 2 + 3 << 4 > (5 - 5 % 6) << 7");

			Check(false, RelationalExpression.S, "5 >");
			Check(false, RelationalExpression.S, "5 > = 6");
			Check(false, RelationalExpression.S, "a is 5");
			Check(false, RelationalExpression.S, "b as 6");

			// TODO: there is a problem with angle brackets
			// because they are considered as a generic type definition
			Check(false, RelationalExpression.S, "a < b > c");
		}

		[TestMethod]
		public void Is_Equality_Expression()
		{
			Check(true, EqualityExpression.S, "5 == 6");
			Check(true, EqualityExpression.S, "5 == 6 == 7");
			Check(true, EqualityExpression.S, "(a - b / 5 >> 6) == false");
			Check(true, EqualityExpression.S, "(a + b % 5 << 6) != this.A() == true");

			Check(false, EqualityExpression.S, "5 = 6");
			Check(false, EqualityExpression.S, "5 = = 6");
			Check(false, EqualityExpression.S, "5 ! = 6");
			Check(false, EqualityExpression.S, "5 == 6 ==");
		}

		[TestMethod]
		public void Is_And_Expression()
		{
			Check(true, AndExpression.S, "a");
			Check(true, AndExpression.S, "a & b");
			Check(true, AndExpression.S, "a == b & c");
			Check(true, AndExpression.S, "(a == 5) & (b - 6)");
			Check(false, AndExpression.S, "a &");
			Check(false, AndExpression.S, "a && b");
		}

		[TestMethod]
		public void Is_Exclusive_Or_Expression()
		{
			Check(true, ExclusiveOrExpression.S, "a");
			Check(true, ExclusiveOrExpression.S, "a ^ b");
			Check(true, ExclusiveOrExpression.S, "a & b ^ c");
			Check(true, ExclusiveOrExpression.S, "(a == 5) ^ (b - 6)");
			Check(false, ExclusiveOrExpression.S, "a ^");
			Check(false, ExclusiveOrExpression.S, "a ^^ b");
		}

		[TestMethod]
		public void Is_Inclusive_Or_Expression()
		{
			Check(true, InclusiveOrExpression.S, "a");
			Check(true, InclusiveOrExpression.S, "a | b");
			Check(true, InclusiveOrExpression.S, "a ^ b | c");
			Check(true, InclusiveOrExpression.S, "(a == 5) | (b - 6)");
			Check(false, InclusiveOrExpression.S, "a |");
			Check(false, InclusiveOrExpression.S, "a || b");
		}

		[TestMethod]
		public void Is_Conditional_And_Expression()
		{
			Check(true, ConditionalAndExpression.S, "a");
			Check(true, ConditionalAndExpression.S, "a && b");
			Check(true, ConditionalAndExpression.S, "a | b && c");
			Check(true, ConditionalAndExpression.S, "(a == 5) && (b - 6)");
			Check(false, ConditionalAndExpression.S, "a &&");
			Check(false, ConditionalAndExpression.S, "a &&& b");
		}

		[TestMethod]
		public void Is_Conditional_Or_Expression()
		{
			Check(true, ConditionalOrExpression.S, "a");
			Check(true, ConditionalOrExpression.S, "a || b");
			Check(true, ConditionalOrExpression.S, "a && b || c");
			Check(true, ConditionalOrExpression.S, "(a == 5) || (b - 6)");
			Check(false, ConditionalOrExpression.S, "a ||");
			Check(false, ConditionalOrExpression.S, "a ||| b");
		}

		[TestMethod]
		public void Is_Null_Coalescing_Expression()
		{
			Check(true, NullCoalescingExpression.S, "a");
			Check(true, NullCoalescingExpression.S, "a || b == c");
			Check(true, NullCoalescingExpression.S, "a ?? b");
			Check(true, NullCoalescingExpression.S, "a || b ?? c == d ?? a - b");
			Check(false, NullCoalescingExpression.S, "a ? b");
			Check(false, NullCoalescingExpression.S, "a ??");
			Check(false, NullCoalescingExpression.S, "a ?? b ??");
		}

		[TestMethod]
		public void Is_Conditional_Expression()
		{
			Check(true, ConditionalExpression.S, "a");
			Check(true, ConditionalExpression.S, "a ? b : c");
			Check(true, ConditionalExpression.S, "a || b ? c == d : this.A()");
			Check(true, ConditionalExpression.S, "a ? b : c ? d : e");
			Check(false, ConditionalExpression.S, "a ? b :");
			Check(false, ConditionalExpression.S, "a ?? b : c");
			Check(false, ConditionalExpression.S, "a ? b :: c");
		}

		[TestMethod]
		public void Is_Lambda_Expression()
		{
			Check(true, LambdaExpression.S, "(int x, int y) => x + y");
			Check(true, LambdaExpression.S, "() => 5");
			Check(true, LambdaExpression.S, "(x, y) => x + y");
			//xxxCheck(true, LambdaExpression.S, "(x, y) => { return x + y; }");
			Check(false, LambdaExpression.S, "x, y => x + y");
			Check(false, LambdaExpression.S, "(x, y) <= x + y");
		}

		[TestMethod]
		public void Is_Lambda_Expression_Additional()
		{
			Check(true, LambdaExpression.S, "x => x + 1");
			//xxxCheck(true, LambdaExpression.S, "x => { return x + 1; }");
			Check(true, LambdaExpression.S, "(int x) => x + 1");
			//xxxCheck(true, LambdaExpression.S, "(int x) => { return x + 1; }");
			Check(true, LambdaExpression.S, "(int x, int y) => x - y");
			//xxxCheck(true, LambdaExpression.S, "(int x, int y) => { return x - y; }");
			Check(true, LambdaExpression.S, "(x, y) => x * y");
			//xxxCheck(true, LambdaExpression.S, "(x, y) => { return x * y; }");
			Check(true, LambdaExpression.S, "() => Console.WriteLine()");
			//xxxCheck(true, LambdaExpression.S, "() => { Console.WriteLine(); }");

			Check(true, LambdaExpression.S, "x => x + 1");
			//xxxCheck(true, LambdaExpression.S, "x => { return x + 1; }");
			Check(true, LambdaExpression.S, "(int x) => x + 1");
			//xxxCheck(true, LambdaExpression.S, "(int x) => { return x + 1; }");
			Check(true, LambdaExpression.S, "(int x, int y) => x - y");
			//xxxCheck(true, LambdaExpression.S, "(int x, int y) => { return x - y; }");
			Check(true, LambdaExpression.S, "(x, y) => x * y");
			//xxxCheck(true, LambdaExpression.S, "(x, y) => { return x * y; }");
			Check(true, LambdaExpression.S, "() => Console.WriteLine()");
			//xxxCheck(true, LambdaExpression.S, "() => { Console.WriteLine(); }");
		}

		[TestMethod]
		public void Is_Anonymous_Method_Expression()
		{
			//xxx
			//Check(true, AnonymousMethodExpression.S, "delegate { return x + y; }");
			//Check(true, AnonymousMethodExpression.S, "delegate (int x, int y) { return x + y; }");
			//Check(false, AnonymousMethodExpression.S, "delegate (x, y) { return x + y; }");
			//Check(false, AnonymousMethodExpression.S, "delegate (int x, int y) { }");
			//Check(false, AnonymousMethodExpression.S, "delegate (int x, int y)");
		}

		[TestMethod]
		public void Is_Anonymous_Function_Signature()
		{
			Check(true, AnonymousFunctionSignature.S, "()");
			Check(true, AnonymousFunctionSignature.S, "(int x, ref byte[] y)");
			Check(true, AnonymousFunctionSignature.S, "(abc)");
			Check(true, AnonymousFunctionSignature.S, "abc");
		}

		[TestMethod]
		public void Is_Explicit_Anonymous_Function_Signature()
		{
			Check(true, ExplicitAnonymousFunctionSignature.S, "()");
			Check(true, ExplicitAnonymousFunctionSignature.S, "(int x, ref byte[] y)");
			Check(false, ExplicitAnonymousFunctionSignature.S, "(abc)");
			Check(false, ExplicitAnonymousFunctionSignature.S, "abc");
			Check(false, ExplicitAnonymousFunctionSignature.S, "(x, y)");
			Check(false, ExplicitAnonymousFunctionSignature.S, "x, y");
		}

		[TestMethod]
		public void Is_Explicit_Anonymous_Function_Parameter_List()
		{
			Check(true, ExplicitAnonymousFunctionParameterList.S, "int a, ref bool b");
			Check(false, ExplicitAnonymousFunctionParameterList.S, "int a, ref bool b,");
		}

		[TestMethod]
		public void Is_Explicit_Anonymous_Function_Parameter()
		{
			Check(true, ExplicitAnonymousFunctionParameter.S, "int a");
			Check(true, ExplicitAnonymousFunctionParameter.S, "ref int a");
			Check(true, ExplicitAnonymousFunctionParameter.S, "out int a");
			Check(false, ExplicitAnonymousFunctionParameter.S, "abc");
			Check(false, ExplicitAnonymousFunctionParameter.S, "int 1");
			Check(false, ExplicitAnonymousFunctionParameter.S, "in int a");
		}

		[TestMethod]
		public void Is_Anonymous_Function_Parameter_Modifier()
		{
			Check(true, AnonymousFunctionParameterModifier.S, "ref");
			Check(true, AnonymousFunctionParameterModifier.S, "out");
			Check(false, AnonymousFunctionParameterModifier.S, "in");
		}

		[TestMethod]
		public void Is_Implicit_Anonymous_Function_Signature()
		{
			Check(true, ImplicitAnonymousFunctionSignature.S, "()");
			Check(true, ImplicitAnonymousFunctionSignature.S, "(x, y)");
			Check(true, ImplicitAnonymousFunctionSignature.S, "(abc)");
			Check(true, ImplicitAnonymousFunctionSignature.S, "abc");
			Check(false, ImplicitAnonymousFunctionSignature.S, "x, y");
		}

		[TestMethod]
		public void Is_Implicit_Anonymous_Function_Parameter_List()
		{
			Check(true, ImplicitAnonymousFunctionParameterList.S, "Abc, d");
			Check(false, ImplicitAnonymousFunctionParameterList.S, "Abc, d,");
		}

		[TestMethod]
		public void Is_Implicit_Anonymous_Function_Parameter()
		{
			Check(true, ImplicitAnonymousFunctionParameter.S, "Abc1");
			Check(false, ImplicitAnonymousFunctionParameter.S, "1Abc");
		}

		[TestMethod]
		public void Is_Anonymous_Function_Body()
		{
			Check(true, AnonymousFunctionBody.S, "5");
			Check(true, AnonymousFunctionBody.S, "a + b");
			Check(false, AnonymousFunctionBody.S, "!");

			//xxxBLOCK
		}

		//xxx

		[TestMethod]
		public void Is_Query_Expression_Additional()
		{
			Check(true, QueryExpression.S, Syntactic.QueryExpression1);
			Check(true, QueryExpression.S, Syntactic.QueryExpression2);
			Check(true, QueryExpression.S, Syntactic.QueryExpression3);
			Check(true, QueryExpression.S, Syntactic.QueryExpression4);
			Check(true, QueryExpression.S, Syntactic.QueryExpression5);
			Check(true, QueryExpression.S, Syntactic.QueryExpression6);
			Check(true, QueryExpression.S, Syntactic.QueryExpression7);
			Check(true, QueryExpression.S, Syntactic.QueryExpression8);
			Check(true, QueryExpression.S, Syntactic.QueryExpression9);
			Check(true, QueryExpression.S, Syntactic.QueryExpression10);
			Check(true, QueryExpression.S, Syntactic.QueryExpression11);
			Check(true, QueryExpression.S, Syntactic.QueryExpression12);
			Check(true, QueryExpression.S, Syntactic.QueryExpression13);
			Check(true, QueryExpression.S, Syntactic.QueryExpression14);
			Check(true, QueryExpression.S, Syntactic.QueryExpression15);
			Check(true, QueryExpression.S, Syntactic.QueryExpression16);
			Check(true, QueryExpression.S, Syntactic.QueryExpression17);
			Check(true, QueryExpression.S, Syntactic.QueryExpression18);
			Check(true, QueryExpression.S, Syntactic.QueryExpression19);
		}

		[TestMethod]
		public void Is_Assignment()
		{
			Check(true, Assignment.S, "a = 5");
			Check(true, Assignment.S, "a >>= 5");
			Check(true, Assignment.S, "a = b = c");
			Check(true, Assignment.S, "a = (b + c) / 25 >> 30");
			Check(true, Assignment.S, "--this.A()++ = !!~~this.B()");
			Check(false, Assignment.S, "a != b");
			Check(false, Assignment.S, "a = (b + c) / 25 >>= 30");
		}

		[TestMethod]
		public void Is_Assignment_Operator()
		{
			Check(true, AssignmentOperator.S, "=");
			Check(true, AssignmentOperator.S, "+=");
			Check(true, AssignmentOperator.S, "-=");
			Check(true, AssignmentOperator.S, "*=");
			Check(true, AssignmentOperator.S, "/=");
			Check(true, AssignmentOperator.S, "%=");
			Check(true, AssignmentOperator.S, "&=");
			Check(true, AssignmentOperator.S, "|=");
			Check(true, AssignmentOperator.S, "^=");
			Check(true, AssignmentOperator.S, "^=");
			Check(true, AssignmentOperator.S, "<<=");
			Check(true, AssignmentOperator.S, ">>=");

			Check(false, AssignmentOperator.S, "==");
			Check(false, AssignmentOperator.S, "<<");
			Check(false, AssignmentOperator.S, ">>");
			Check(false, AssignmentOperator.S, ">> =");
			Check(false, AssignmentOperator.S, "> >=");
			Check(false, AssignmentOperator.S, "> > =");
		}

		[TestMethod]
		public void Is_Expression()
		{
			Check(true, Expression.S, "(a + b) || (c >> d) ? c ^ d : this.A()");
			Check(true, Expression.S, "(x, y) => x + y");
			//xxxQUERY
			Check(true, Expression.S, "a = b = c");
		}

		[TestMethod]
		public void Is_Non_Assignment_Expression()
		{
			Check(true, NonAssignmentExpression.S, "(a + b) || (c >> d) ? c ^ d : this.A()");
			Check(true, NonAssignmentExpression.S, "(x, y) => x + y");
			//xxxQUERY
			Check(false, NonAssignmentExpression.S, "a = b = c");
		}

		[TestMethod]
		public void Is_Constant_Expression()
		{
			Check(true, ConstantExpression.S, "5");
			Check(true, ConstantExpression.S, "a + b");
			Check(false, ConstantExpression.S, "!");
		}

		[TestMethod]
		public void Is_Boolean_Expression()
		{
			Check(true, BooleanExpression.S, "5");
			Check(true, BooleanExpression.S, "a + b");
			Check(false, BooleanExpression.S, "!");
		}
	}
}