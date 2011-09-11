using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ClassMemberDeclarations : ParseMany
	{
		public static readonly ClassMemberDeclarations S = new ClassMemberDeclarations();
		public static readonly Optional O = new Optional(S);

		public ClassMemberDeclarations()
			: base(ClassMemberDeclaration.S)
		{
		}
	}
}
