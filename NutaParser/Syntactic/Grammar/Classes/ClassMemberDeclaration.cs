using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ClassMemberDeclaration : ParseAny
	{
		public static readonly ClassMemberDeclaration S = new ClassMemberDeclaration();

		public ClassMemberDeclaration()
			: base(
				ConstantDeclaration.S,
				FieldDeclaration.S,
				MethodDeclaration.S,
				PropertyDeclaration.S,
				EventDeclaration.S,
				IndexerDeclaration.S,
				OperatorDeclaration.S,
				ConstructorDeclaration.S,
				DestructorDeclaration.S,
				StaticConstructorDeclaration.S,
				TypeDeclaration.S)
		{
		}
	}
}
