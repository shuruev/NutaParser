using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Margin : ParseAll
	{
		public static readonly Margin S = new Margin();

		public Margin()
			: base(
				MarginSymbol.S,
				Whitespaces.O,
				LeftCurlyBracketTerminal.S,
				DeclarationList.S,
				RightCurlyBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
