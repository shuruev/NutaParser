using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class KeyframeBlock : ParseAll
	{
		public static readonly KeyframeBlock S = new KeyframeBlock();

		public KeyframeBlock()
			: base(
				KeyframeSelectorList.S,
				LeftCurlyBracketTerminal.S,
				DeclarationList.S,
				RightCurlyBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
