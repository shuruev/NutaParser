namespace NutaParser.Syntactic.Grammar
{
	public class UsingDirective : ParseAny
	{
		public static readonly UsingDirective S = new UsingDirective();

		public UsingDirective()
			: base(
				UsingAliasDirective.S,
				UsingNamespaceDirective.S)
		{
		}
	}
}
