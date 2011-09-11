using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EnumDeclaration : ParseAll
	{
		public static readonly EnumDeclaration S = new EnumDeclaration();

		public EnumDeclaration()
			: base(
				Attributes.O,
				EnumModifiers.O,
				EnumTerminal.S,
				IdentifierTerminal.S,
				EnumBase.O,
				EnumBody.S,
				SemicolonTerminal.O)
		{
		}
	}
}
