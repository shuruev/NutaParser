using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SelectorList : ParseMany
	{
		public static readonly SelectorList S = new SelectorList();

		public SelectorList()
			: base(
				Selector.S,
				new ParseAll(
					CommaTerminal.S,
					WhitespaceTerminal.O))
		{
		}
	}
}
