using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Types : GrammarTest
	{
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
		}
	}
}
