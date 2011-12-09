using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class DeclarationList : ParseMany
	{
		public static readonly DeclarationList S = new DeclarationList();

		public DeclarationList()
			: base(
				new ParseAll(Whitespaces.O, Declaration.O),
				SemicolonTerminal.S)
		{
		}
	}
}
