using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NamespaceMemberDeclarations : ParseMany
	{
		public static readonly NamespaceMemberDeclarations S = new NamespaceMemberDeclarations();
		public static readonly Optional O = new Optional(S);

		public NamespaceMemberDeclarations()
			: base(NamespaceMemberDeclaration.S)
		{
		}
	}
}
