namespace NutaParser.Syntactic.Grammar
{
	public class NamespaceName : ParseAny
	{
		public static readonly NamespaceName S = new NamespaceName();

		public NamespaceName()
			: base(NamespaceOrTypeName.S)
		{
		}
	}
}
