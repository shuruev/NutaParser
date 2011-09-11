using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class RightAngleBracketTerminal : TextTerminal
	{
		public static readonly RightAngleBracketTerminal S = new RightAngleBracketTerminal();

		public RightAngleBracketTerminal()
			: base(">")
		{
		}
	}
}
