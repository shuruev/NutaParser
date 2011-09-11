using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
