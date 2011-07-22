namespace NutaParser.Syntactic.Grammar
{
	public class RightSquareBracketTerminal : TextTerminal
	{
		public static readonly RightSquareBracketTerminal S = new RightSquareBracketTerminal();

		public RightSquareBracketTerminal()
			: base("]")
		{
		}
	}
}
