using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
