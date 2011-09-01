namespace NutaParser.Syntactic.Grammar
{
	public class CompilationUnit : ParseAll
	{
		public static readonly CompilationUnit S = new CompilationUnit();

		public CompilationUnit()
			: base(
				/*xxx*/
				GlobalAttributes.O,
				NamespaceMemberDeclarations.O)
		{
		}
	}
}
