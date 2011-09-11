using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Syntactic;

namespace Nuta.Parser.CSharp.Tests.Syntactic
{
	[TestClass]
	public class Interfaces : SyntacticTest
	{
		[TestMethod]
		public void Is_Interface_Declaration()
		{
			Check(true, InterfaceDeclaration.S, "interface IData { }");
			Check(true, InterfaceDeclaration.S, "interface IData { };");
			Check(true, InterfaceDeclaration.S, "[SomeAttribute] public partial interface IData { string GetName(); }");
			Check(true, InterfaceDeclaration.S, "interface IData<in T, out T> : IList where T : new() { }");
		}

		[TestMethod]
		public void Is_Interface_Declaration_Additional()
		{
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration1);
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration2);
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration3);
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration4);
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration5);
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration6);
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration7);
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration8);
			Check(true, InterfaceDeclaration.S, Syntactic.InterfaceDeclaration9);
		}

		[TestMethod]
		public void Is_Interface_Modifiers()
		{
			Check(true, InterfaceModifiers.S, "public private");
			Check(true, InterfaceModifiers.S, "public public");
		}

		[TestMethod]
		public void Is_Interface_Modifier()
		{
			Check(false, InterfaceModifier.S, "abstract");
			Check(false, InterfaceModifier.S, "extern");
			Check(true, InterfaceModifier.S, "internal");
			Check(false, InterfaceModifier.S, "internal protected");
			Check(true, InterfaceModifier.S, "new");
			Check(false, InterfaceModifier.S, "override");
			Check(true, InterfaceModifier.S, "private");
			Check(true, InterfaceModifier.S, "protected");
			Check(false, InterfaceModifier.S, "protected internal");
			Check(true, InterfaceModifier.S, "public");
			Check(false, InterfaceModifier.S, "readonly");
			Check(false, InterfaceModifier.S, "sealed");
			Check(false, InterfaceModifier.S, "static");
			Check(false, InterfaceModifier.S, "unsafe");
			Check(false, InterfaceModifier.S, "virtual");
			Check(false, InterfaceModifier.S, "volatile");
		}

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

		[TestMethod]
		public void Is_Interface_Base()
		{
			Check(true, InterfaceBase.S, ": IList");
			Check(true, InterfaceBase.S, ": IList, IEnumerable<int>");
			Check(false, InterfaceBase.S, "IList");
			Check(false, InterfaceBase.S, ": IList,");
		}

		[TestMethod]
		public void Is_Interface_Body()
		{
			Check(true, InterfaceBody.S, "{ }");
			Check(true, InterfaceBody.S, "{ string GetName(); }");
			Check(true, InterfaceBody.S, "{ string GetName(); string Name { get; } }");
			Check(false, InterfaceBody.S, "{ string GetName() }");
			Check(false, InterfaceBody.S, "{ string GetName(); string Name { get; }; }");
		}

		[TestMethod]
		public void Is_Interface_Member_Declarations()
		{
			Check(true, InterfaceMemberDeclarations.S, "string GetName(); string Name { get; }");
			Check(false, InterfaceMemberDeclarations.S, "string GetName(); string Name { get; };");
		}

		[TestMethod]
		public void Is_Interface_Member_Declaration()
		{
			Check(true, InterfaceMemberDeclaration.S, "string GetName();");
			Check(true, InterfaceMemberDeclaration.S, "string Name { get; set; }");
			Check(true, InterfaceMemberDeclaration.S, "event EventHandler<SomeArgs> Click;");
			Check(true, InterfaceMemberDeclaration.S, "string this[int index] { get; set; }");
		}

		[TestMethod]
		public void Is_Interface_Method_Declaration()
		{
			Check(true, InterfaceMethodDeclaration.S, "string GetName();");
			Check(true, InterfaceMethodDeclaration.S, "string GetName(int index);");
			Check(true, InterfaceMethodDeclaration.S, "[SomeAttribute] new string GetName(int index);");
			Check(true, InterfaceMethodDeclaration.S, "string GetName<T>();");
			Check(true, InterfaceMethodDeclaration.S, "string GetName<T>() where T : IEnumerable, new();");
			Check(false, InterfaceMethodDeclaration.S, "public string GetName();");
			Check(false, InterfaceMethodDeclaration.S, "string GetName()");
		}

		[TestMethod]
		public void Is_Interface_Property_Declaration()
		{
			Check(true, InterfacePropertyDeclaration.S, "string Name { get; set; }");
			Check(true, InterfacePropertyDeclaration.S, "[SomeAttribute] new string Name { get; [SomeAttribute] set; }");
			Check(false, InterfacePropertyDeclaration.S, "public string Name { get; set; }");
			Check(false, InterfacePropertyDeclaration.S, "string Name { }");
		}

		[TestMethod]
		public void Is_Interface_Accessors()
		{
			Check(true, InterfaceAccessors.S, "get;");
			Check(true, InterfaceAccessors.S, "set;");
			Check(true, InterfaceAccessors.S, "get; set;");
			Check(true, InterfaceAccessors.S, "set; get;");
			Check(true, InterfaceAccessors.S, "[SomeAttribute] get; [SomeAttribute] set;");
			Check(false, InterfaceAccessors.S, "get");
			Check(false, InterfaceAccessors.S, "get; [SomeAttribute];");
			Check(false, InterfaceAccessors.S, "set; set;");
		}

		[TestMethod]
		public void Is_Interface_Event_Declaration()
		{
			Check(true, InterfaceEventDeclaration.S, "event EventHandler<SomeArgs> Click;");
			Check(true, InterfaceEventDeclaration.S, "[SomeAttribute] new event EventHandler<SomeArgs> Click;");
			Check(false, InterfaceEventDeclaration.S, "event EventHandler<SomeArgs> Click");
			Check(false, InterfaceEventDeclaration.S, "public event EventHandler<SomeArgs> Click;");
		}

		[TestMethod]
		public void Is_Interface_Indexer_Declaration()
		{
			Check(true, InterfaceIndexerDeclaration.S, "string this[int index] { get; set; }");
			Check(true, InterfaceIndexerDeclaration.S, "[SomeAttribute] new string this[int index] { get; [SomeAttribute] set; }");
			Check(false, InterfaceIndexerDeclaration.S, "string this[] { get; set; }");
			Check(false, InterfaceIndexerDeclaration.S, "string this[int index] { }");
		}
	}
}
