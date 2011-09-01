namespace NutaParser.Syntactic.Grammar
{
	public class UsingAliasDirective : ParseAll
	{
		public static readonly UsingAliasDirective S = new UsingAliasDirective();

		public UsingAliasDirective()
			: base(
				UsingTerminal.S,
				IdentifierTerminal.S,
				EqualTerminal.S,
				NamespaceName.S,
				SemicolonTerminal.S)
		{
		}
	}
}
