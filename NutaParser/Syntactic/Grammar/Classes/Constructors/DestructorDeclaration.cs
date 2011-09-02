namespace NutaParser.Syntactic.Grammar
{
	public class DestructorDeclaration : ParseAll
	{
		public static readonly DestructorDeclaration S = new DestructorDeclaration();

		public DestructorDeclaration()
			: base(
				Attributes.O,
				ExternTerminal.O,
				TildeTerminal.S,
				IdentifierTerminal.S,
				LeftRoundBracketTerminal.S,
				RightRoundBracketTerminal.S,
				DestructorBody.S)
		{
		}
	}
}
