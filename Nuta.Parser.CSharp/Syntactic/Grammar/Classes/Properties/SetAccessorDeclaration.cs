using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SetAccessorDeclaration : ParseAll
	{
		public static readonly SetAccessorDeclaration S = new SetAccessorDeclaration();

		public SetAccessorDeclaration()
			: base(
				Attributes.O,
				AccessorModifier.O,
				SetTerminal.S,
				AccessorBody.S)
		{
		}
	}
}
