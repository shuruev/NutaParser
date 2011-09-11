using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
