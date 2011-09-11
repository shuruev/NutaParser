using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceMemberDeclarations : ParseMany
	{
		public static readonly InterfaceMemberDeclarations S = new InterfaceMemberDeclarations();
		public static readonly Optional O = new Optional(S);

		public InterfaceMemberDeclarations()
			: base(InterfaceMemberDeclaration.S)
		{
		}
	}
}
