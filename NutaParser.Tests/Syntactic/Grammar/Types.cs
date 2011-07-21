using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Types : GrammarTest
	{
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
	}
}
