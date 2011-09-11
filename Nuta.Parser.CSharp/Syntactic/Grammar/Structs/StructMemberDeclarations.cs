using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StructMemberDeclarations : ParseMany
	{
		public static readonly StructMemberDeclarations S = new StructMemberDeclarations();
		public static readonly Optional O = new Optional(S);

		public StructMemberDeclarations()
			: base(StructMemberDeclaration.S)
		{
		}
	}
}
