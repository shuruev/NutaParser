using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AccessorDeclarations : ParseAny
	{
		public static readonly AccessorDeclarations S = new AccessorDeclarations();

		public AccessorDeclarations()
			: base(
				new ParseAll(GetAccessorDeclaration.S, SetAccessorDeclaration.S),
				new ParseAll(SetAccessorDeclaration.S, GetAccessorDeclaration.S),
				GetAccessorDeclaration.S,
				SetAccessorDeclaration.S)
		{
		}
	}
}
