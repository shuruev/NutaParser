using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Interfaces : GrammarTest
	{
		//xxx

		[TestMethod]
		public void Is_Variant_Type_Parameter_List()
		{
			Check(true, VariantTypeParameterList.S, "<T>");
			Check(true, VariantTypeParameterList.S, "<in TKey, out TValue>");
			Check(true, VariantTypeParameterList.S, "<in TKey, out TValue, [SomeAttribute] TOther>");
		}

		[TestMethod]
		public void Is_Variant_Type_Parameters()
		{
			Check(true, VariantTypeParameters.S, "T");
			Check(true, VariantTypeParameters.S, "in TKey, out TValue");
			Check(true, VariantTypeParameters.S, "in TKey, out TValue, [SomeAttribute] TOther");
			Check(false, VariantTypeParameters.S, "in TKey, out TValue,");
		}

		[TestMethod]
		public void Is_Variance_Annotation()
		{
			Check(true, VarianceAnnotation.S, "in");
			Check(true, VarianceAnnotation.S, "out");
			Check(false, VarianceAnnotation.S, "ref");
		}

		//xxx
	}
}
