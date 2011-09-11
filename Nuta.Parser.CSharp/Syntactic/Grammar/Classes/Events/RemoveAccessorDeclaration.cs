using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class RemoveAccessorDeclaration : ParseAll
	{
		public static readonly RemoveAccessorDeclaration S = new RemoveAccessorDeclaration();

		public RemoveAccessorDeclaration()
			: base(
				Attributes.O,
				RemoveTerminal.S,
				Block.S)
		{
		}
	}
}
