﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Types : GrammarTest
	{
		[TestMethod]
		public void Is_Type()
		{
			Check(true, Type.S, "global::abc");
			Check(true, Type.S, "abc[][][]");
			Check(true, Type.S, "abc<bool?>[]");
			Check(true, Type.S, "bool");
			Check(true, Type.S, "bool?");
			Check(true, Type.S, "string");
			Check(true, Type.S, "object");
			Check(true, Type.S, "abc");
			Check(false, Type.S, "void");
			Check(false, Type.S, "null");
		}

		[TestMethod]
		public void Is_Value_Type()
		{
			Check(true, ValueType.S, "global::abc");
			Check(true, ValueType.S, "byte");
			Check(true, ValueType.S, "bool?");
			Check(false, ValueType.S, "string");
			Check(false, ValueType.S, "object");
			Check(false, ValueType.S, "null");
		}

		[TestMethod]
		public void Is_Struct_Type()
		{
			Check(true, StructType.S, "global::abc");
			Check(true, StructType.S, "byte");
			Check(true, StructType.S, "bool?");
			Check(false, StructType.S, "string");
			Check(false, StructType.S, "object");
			Check(false, StructType.S, "null");
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
		public void Is_Nullable_Type()
		{
			Check(false, NullableType.S, "bool");
			Check(true, NullableType.S, "bool?");
			Check(false, NullableType.S, "null");
			Check(false, NullableType.S, "null?");
		}

		[TestMethod]
		public void Is_Non_Nullable_Value_Type()
		{
			Check(true, NonNullableValueType.S, "bool");
			Check(false, NonNullableValueType.S, "bool?");
			Check(false, NonNullableValueType.S, "null");
			Check(false, NonNullableValueType.S, "null?");
		}

		[TestMethod]
		public void Is_Enum_Type()
		{
			Check(true, EnumType.S, "State");
			Check(true, EnumType.S, "State<bool>");
			Check(false, EnumType.S, "object");
			Check(false, EnumType.S, "null");
		}

		[TestMethod]
		public void Is_Reference_Type()
		{
			Check(true, ReferenceType.S, "abc");
			Check(true, ReferenceType.S, "abc[]");
			Check(true, ReferenceType.S, "abc<bool>");
			Check(true, ReferenceType.S, "abc<bool?>");
			Check(true, ReferenceType.S, "abc<bool>[]");
			Check(true, ReferenceType.S, "object");
			Check(false, ReferenceType.S, "bool");
			Check(false, ReferenceType.S, "bool?");
			Check(false, ReferenceType.S, "abc[]<bool>");
			Check(false, ReferenceType.S, "null");
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
		public void Is_Array_Type()
		{
			//xxx
			Check(true, ArrayType.S, "abc[][][]");

			Check(false, ArrayType.S, "bool");
			Check(true, ArrayType.S, "bool[]");
			Check(true, ArrayType.S, "int[][]");
			Check(true, ArrayType.S, "abc[][][]");
			Check(false, ArrayType.S, "void");
			Check(false, ArrayType.S, "void[]");
		}

		[TestMethod]
		public void Is_Non_Array_Type()
		{
			Check(true, NonArrayType.S, "bool");
			Check(true, NonArrayType.S, "bool[]");
			Check(true, NonArrayType.S, "int[][]");
			Check(false, NonArrayType.S, "void");
			Check(false, NonArrayType.S, "void[]");
		}

		[TestMethod]
		public void Is_Rank_Specifiers()
		{
			Check(true, RankSpecifiers.S, "[]");
			Check(true, RankSpecifiers.S, "[][]");
			Check(true, RankSpecifiers.S, "[,][,]");
			Check(false, RankSpecifiers.S, "[,],[,]");
			Check(false, RankSpecifiers.S, "[.][.]");
		}

		[TestMethod]
		public void Is_Rank_Specifier()
		{
			Check(true, RankSpecifier.S, "[]");
			Check(true, RankSpecifier.S, "[ ]");
			Check(true, RankSpecifier.S, "[,]");
			Check(true, RankSpecifier.S, "[ , , ]");
			Check(false, RankSpecifier.S, "[,.]");
			Check(false, RankSpecifier.S, "[,]]");
			Check(false, RankSpecifier.S, "[");
			Check(false, RankSpecifier.S, "]");
			Check(false, RankSpecifier.S, ",");
		}

		[TestMethod]
		public void Is_Dim_Separators()
		{
			Check(true, DimSeparators.S, ",");
			Check(true, DimSeparators.S, ",,,");
			Check(true, DimSeparators.S, " , , , ");
			Check(false, DimSeparators.S, " , . , ");
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
		public void Is_Type_Argument_List()
		{
			Check(true, TypeArgumentList.S, "< byte >");
			Check(true, TypeArgumentList.S, "<byte>");
			Check(true, TypeArgumentList.S, "<byte, bool>");
			Check(false, TypeArgumentList.S, "byte, bool>");
			Check(false, TypeArgumentList.S, "<<byte, bool>");
			Check(false, TypeArgumentList.S, "<byte, bool");
			Check(false, TypeArgumentList.S, "<byte, bool>>");
		}

		[TestMethod]
		public void Is_Type_Arguments()
		{
			Check(true, TypeArguments.S, "byte");
			Check(true, TypeArguments.S, "byte, bool");
			Check(false, TypeArgument.S, "byte, false");
			Check(false, TypeArgument.S, "byte bool");
			Check(false, TypeArgument.S, "byte-bool");
		}

		[TestMethod]
		public void Is_Type_Argument()
		{
			Check(true, TypeArgument.S, "byte");
			Check(true, TypeArgument.S, "bool");
			Check(false, TypeArgument.S, "void");
			Check(false, TypeArgument.S, "false");
		}

		[TestMethod]
		public void Is_Type_Parameters()
		{
			Check(true, TypeParameter.S, " Abc1 ");
			Check(false, TypeParameter.S, " 1Abc ");
		}
	}
}