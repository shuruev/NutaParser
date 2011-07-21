namespace NutaParser.Lexical.Grammar
{
	public class RightRoundBracketTerminal : SingleCharacterTerminal
	{
		public static readonly RightRoundBracketTerminal S = new RightRoundBracketTerminal();

		public RightRoundBracketTerminal()
			: base(')')
		{
		}
	}
}
