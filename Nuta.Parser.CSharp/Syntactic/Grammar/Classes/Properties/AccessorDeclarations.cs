using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
