using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class RuleSet : ParseAll
	{
		public static readonly RuleSet S = new RuleSet();

		public RuleSet()
			: base(
				SelectorList.S,
				LeftCurlyBracketTerminal.S,
				DeclarationList.S,
				RightCurlyBracketTerminal.S,
				WhitespaceTerminal.O)
		{
		}
	}
}
