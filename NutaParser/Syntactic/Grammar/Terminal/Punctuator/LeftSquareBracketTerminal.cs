using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class LeftSquareBracketTerminal : TextTerminal
	{
		public static readonly LeftSquareBracketTerminal S = new LeftSquareBracketTerminal();

		public LeftSquareBracketTerminal()
			: base("[")
		{
		}
	}
}
