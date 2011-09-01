namespace NutaParser.Syntactic.Grammar
{
	public class CompilationUnit : ParseAll
	{
		public static readonly CompilationUnit S = new CompilationUnit();

		public CompilationUnit()
			: base(
				ExternAliasDirectives.O,
				UsingDirectives.O,
				GlobalAttributes.O,
				NamespaceMemberDeclarations.O)
		{
		}
	}
}
