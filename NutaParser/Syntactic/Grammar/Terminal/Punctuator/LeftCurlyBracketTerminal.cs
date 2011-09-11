using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class LeftCurlyBracketTerminal : TextTerminal
	{
		public static readonly LeftCurlyBracketTerminal S = new LeftCurlyBracketTerminal();

		public LeftCurlyBracketTerminal()
			: base("{")
		{
		}
	}
}
