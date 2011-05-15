namespace NutaParser.Lexical.Grammar
{
	public class RightRoundBracket : SingleCharacterTerminal
	{
		public static readonly RightRoundBracket S = new RightRoundBracket();

		public RightRoundBracket()
			: base(')')
		{
		}
	}
}
