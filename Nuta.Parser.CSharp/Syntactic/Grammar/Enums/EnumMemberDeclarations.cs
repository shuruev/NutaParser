using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EnumMemberDeclarations : ParseMany
	{
		public static readonly EnumMemberDeclarations S = new EnumMemberDeclarations();

		public EnumMemberDeclarations()
			: base(EnumMemberDeclaration.S, CommaTerminal.S)
		{
		}
	}
}
