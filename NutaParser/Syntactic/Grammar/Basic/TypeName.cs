namespace NutaParser.Syntactic.Grammar
{
	public class TypeName : ParseAny
	{
		public static readonly TypeName S = new TypeName();

		public TypeName()
			: base(NamespaceOrTypeName.S)
		{
		}
	}
}
