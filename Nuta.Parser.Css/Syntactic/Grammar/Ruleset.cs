using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Ruleset : ParseAll
	{
		public static readonly Ruleset S = new Ruleset();

		public Ruleset()
			: base(
				SelectorList.S,
				LeftCurlyBracketTerminal.S,
				DeclarationList.S,
				RightCurlyBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
