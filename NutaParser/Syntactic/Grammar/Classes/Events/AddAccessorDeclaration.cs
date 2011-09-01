namespace NutaParser.Syntactic.Grammar
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
