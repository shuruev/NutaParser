namespace NutaParser.Syntactic.Grammar
{
	public class IndexerDeclaration : ParseAll
	{
		public static readonly IndexerDeclaration S = new IndexerDeclaration();

		public IndexerDeclaration()
			: base(
				Attributes.O,
				IndexerModifiers.O,
				IndexerDeclarator.S,
				LeftCurlyBracketTerminal.S,
				AccessorDeclarations.S,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
