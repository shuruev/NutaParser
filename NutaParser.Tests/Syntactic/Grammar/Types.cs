using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Types : GrammarTest
	{
		[TestMethod]
		public void Is_Type_Common()
		{
			Check(true, Type.S, "a");
			Check(true, Type.S, "a::b");
			Check(true, Type.S, "a.b.c");
			Check(true, Type.S, "a::b.c");
			Check(false, Type.S, "1.2.3");

			Check(true, Type.S, "a<b>");
			Check(false, Type.S, "a<>");
			Check(true, Type.S, "a.b<c>");
			Check(true, Type.S, "a<b>.c<d>");
			Check(false, Type.S, "a<b>.c<>");
			Check(true, Type.S, "a<b, c>");
			Check(true, Type.S, "a<b, c<d>>");
			Check(true, Type.S, "a<b, c<d, e>>");

			Check(true, Type.S, "a[]");
			Check(true, Type.S, "a[][]");
			Check(false, Type.S, "a[]b[]");
			Check(true, Type.S, "a<b>[]");
			Check(true, Type.S, "a<b[]>");
			Check(false, Type.S, "a[]<b>");
			Check(true, Type.S, "a<b[]>[]");
			Check(false, Type.S, "a[]<b[]>[]");
			Check(true, Type.S, "a<b[][], c<d[][], e[][]>[][]>[][]");

			Check(true, Type.S, "a?");
			Check(false, Type.S, "a??");
			Check(true, Type.S, "a<b>?");
			Check(true, Type.S, "a<b?>");
			Check(false, Type.S, "a?<b>");
			Check(true, Type.S, "a<b?>?");
			Check(false, Type.S, "a?<b?>?");
			Check(true, Type.S, "a<b?, c<d?, e?>?>?");

			Check(true, Type.S, "a?[]");
			Check(false, Type.S, "a[]?");
			Check(true, Type.S, "a<b>?[]");
			Check(true, Type.S, "a<b?[]>");
			Check(true, Type.S, "a<b?[]>?[][]");
			Check(true, Type.S, "a<b?[][], c<d?[][], e?[][]>?[][]>?[][]");
		}

		[TestMethod]
		public void Is_Type_Additional()
		{
			Check(true, Type.S, "global::abc");
			Check(true, Type.S, "bool");
			Check(true, Type.S, "bool?");
			Check(false, Type.S, "bool??");
			Check(true, Type.S, "string");
			Check(true, Type.S, "object");
			Check(false, Type.S, "void");
			Check(false, Type.S, "null");
			Check(false, Type.S, "null?");

			Check(true, Type.S, "a[]");
			Check(true, Type.S, "a<b>");
			Check(false, Type.S, "a[]<b>");
			Check(true, Type.S, "a<b>[]");
			Check(true, Type.S, "a<b<c>>");

			Check(true, Type.S, "abc");
			Check(true, Type.S, "abc[]");
			Check(true, Type.S, "abc?");
			Check(true, Type.S, "abc[][][]");
			Check(true, Type.S, "abc?[][][]");
			Check(true, Type.S, "abc");
			Check(true, Type.S, "abc<bool>");
			Check(true, Type.S, "abc<bool?>");
			Check(true, Type.S, "abc<bool>[]");
			Check(true, Type.S, "abc<bool?>[]");
			Check(true, Type.S, "abc<bool?>?[]");
			Check(false, Type.S, "abc[][][]?");
			Check(false, Type.S, "abc[][]?[]");
			Check(false, Type.S, "abc[]<bool>");

			Check(true, Type.S, "List<abc>");
			Check(true, Type.S, "List<abc?>");
			Check(true, Type.S, "List<abc>?");
			Check(true, Type.S, "List<abc?>?");
			Check(true, Type.S, "List<List<List<bool>>>");
			Check(true, Type.S, "List<List<List<bool?>?>?>?");
			Check(true, Type.S, "List<bool?>?[][][]");
			Check(true, Type.S, "List<List<bool?[]>[][]>");
			Check(true, Type.S, "Dictionary<List<bool?>?[][][], List<bool?>?[][][]>");

			Check(true, Type.S, "global::A<int?>.B<int, bool>?[][]");
		}

		[TestMethod]
		public void Is_Type_Extremal_Deep()
		{
			Check(
				true,
				Type.S,
				@"
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					List<List<List<List<List<List<List<List<List<List<
					int
					>>>>>>>>>>
					>>>>>>>>>>
					>>>>>>>>>>
					>>>>>>>>>>
					>>>>>>>>>>
					>>>>>>>>>>
					>>>>>>>>>>
					>>>>>>>>>>
					>>>>>>>>>>
					>>>>>>>>>>
				");

			Check(
				true,
				Type.S,
				@"
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					A<A<A<A<A<A<A<A<A<A<
					int
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
					>?>?>?>?>?>?>?>?>?>?
				");

			Check(
				true,
				Type.S,
				@"
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<Ab<
					int
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
					>[]>[]>[]>[]>[]>[]>[]>[]>[]>[]
				");

			Check(
				true,
				Type.S,
				@"
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<Abc<
					int
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
					>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]>?[]
				");
		}

		[TestMethod]
		public void Is_Simple_Type()
		{
			Check(true, SimpleType.S, "byte");
			Check(true, SimpleType.S, "int");
			Check(true, SimpleType.S, "char");
			Check(true, SimpleType.S, "double");
			Check(true, SimpleType.S, "float");
			Check(true, SimpleType.S, "decimal");
			Check(true, SimpleType.S, "bool");
			Check(false, SimpleType.S, "abc");
		}

		[TestMethod]
		public void Is_Numeric_Type()
		{
			Check(true, NumericType.S, "byte");
			Check(true, NumericType.S, "int");
			Check(true, NumericType.S, "char");
			Check(true, NumericType.S, "double");
			Check(true, NumericType.S, "float");
			Check(true, NumericType.S, "decimal");
			Check(false, NumericType.S, "bool");
			Check(false, NumericType.S, "abc");
		}

		[TestMethod]
		public void Is_Integral_Type()
		{
			Check(true, IntegralType.S, "byte");
			Check(true, IntegralType.S, "int");
			Check(true, IntegralType.S, "char");
			Check(false, IntegralType.S, "double");
			Check(false, IntegralType.S, "float");
			Check(false, IntegralType.S, "decimal");
			Check(false, IntegralType.S, "bool");
			Check(false, IntegralType.S, "abc");
		}

		[TestMethod]
		public void Is_Floating_Point_Type()
		{
			Check(false, FloatingPointType.S, "byte");
			Check(false, FloatingPointType.S, "int");
			Check(false, FloatingPointType.S, "char");
			Check(true, FloatingPointType.S, "double");
			Check(true, FloatingPointType.S, "float");
			Check(false, FloatingPointType.S, "decimal");
			Check(false, FloatingPointType.S, "bool");
			Check(false, FloatingPointType.S, "abc");
		}

		[TestMethod]
		public void Is_Class_Type()
		{
			Check(true, ClassType.S, "Class1");
			Check(true, ClassType.S, "Class1<bool>");
			Check(true, ClassType.S, "object");
			Check(true, ClassType.S, "dynamic");
			Check(true, ClassType.S, "string");
			Check(false, ClassType.S, "null");
		}

		[TestMethod]
		public void Is_Interface_Type()
		{
			Check(true, InterfaceType.S, "IEnumerable");
			Check(true, InterfaceType.S, "IEnumerable<bool>");
			Check(false, InterfaceType.S, "object");
			Check(false, InterfaceType.S, "null");
		}

		[TestMethod]
		public void Is_Delegate_Type()
		{
			Check(true, DelegateType.S, "Action");
			Check(true, DelegateType.S, "Action<bool>");
			Check(false, DelegateType.S, "object");
			Check(false, DelegateType.S, "null");
		}

		[TestMethod]
		public void Is_Array_Type()
		{
			Check(true, ArrayType.S, "Abc[]");
			Check(true, ArrayType.S, "Abc?[]");
			Check(true, ArrayType.S, "Abc?[][]");
			Check(false, ArrayType.S, "int");
			Check(false, ArrayType.S, "List<Abc[]>");
			Check(false, ArrayType.S, "Abc[]?");
		}

		[TestMethod]
		public void Is_Type_Parameter()
		{
			Check(true, TypeParameter.S, " Abc1 ");
			Check(false, TypeParameter.S, " 1Abc ");
		}
	}
}
