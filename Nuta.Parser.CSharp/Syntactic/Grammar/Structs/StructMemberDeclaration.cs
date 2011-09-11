using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StructMemberDeclaration : ParseAny
	{
		public static readonly StructMemberDeclaration S = new StructMemberDeclaration();

		public StructMemberDeclaration()
			: base(
				ConstantDeclaration.S,
				FieldDeclaration.S,
				MethodDeclaration.S,
				PropertyDeclaration.S,
				EventDeclaration.S,
				IndexerDeclaration.S,
				OperatorDeclaration.S,
				ConstructorDeclaration.S,
				StaticConstructorDeclaration.S,
				TypeDeclaration.S)
		{
		}
	}
}
