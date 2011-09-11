using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SwitchBlock : ParseAll
	{
		public static readonly SwitchBlock S = new SwitchBlock();

		public SwitchBlock()
			: base(
				LeftCurlyBracketTerminal.S,
				SwitchSections.O,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
