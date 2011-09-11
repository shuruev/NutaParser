using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class GetAccessorDeclaration : ParseAll
	{
		public static readonly GetAccessorDeclaration S = new GetAccessorDeclaration();

		public GetAccessorDeclaration()
			: base(
				Attributes.O,
				AccessorModifier.O,
				GetTerminal.S,
				AccessorBody.S)
		{
		}
	}
}
