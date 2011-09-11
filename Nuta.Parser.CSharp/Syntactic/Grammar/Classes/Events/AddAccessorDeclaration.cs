using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AddAccessorDeclaration : ParseAll
	{
		public static readonly AddAccessorDeclaration S = new AddAccessorDeclaration();

		public AddAccessorDeclaration()
			: base(
				Attributes.O,
				AddTerminal.S,
				Block.S)
		{
		}
	}
}
