using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Arrays : GrammarTest
	{
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
		public void Is_Array_Initializer()
		{
			Check(true, ArrayInitializer.S, "{ }");
			Check(true, ArrayInitializer.S, "{ this.A, }");
			Check(true, ArrayInitializer.S, "{ { a, b }, c }");
			Check(true, ArrayInitializer.S, "{ { a, b }, c, }");
			Check(true, ArrayInitializer.S, "{ 1, 2, 3 }");
			Check(false, ArrayInitializer.S, "{ , }");
			Check(false, ArrayInitializer.S, "{ this.A,, }");
		}

		[TestMethod]
		public void Is_Variable_Initializer_List()
		{
			Check(true, VariableInitializerList.S, "{ a }, b, { c, d, }");
			Check(false, VariableInitializerList.S, "{ a }, b, { c, d, },");
		}

		[TestMethod]
		public void Is_Variable_Initializer()
		{
			Check(true, VariableInitializer.S, "this.A");
			Check(true, VariableInitializer.S, "{ this.A, }");
			Check(true, VariableInitializer.S, "{ { this.A, }, }");
			Check(false, VariableInitializer.S, "{ this.A,, }");
		}
	}
}
