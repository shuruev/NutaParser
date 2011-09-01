namespace NutaParser.Syntactic.Grammar
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
