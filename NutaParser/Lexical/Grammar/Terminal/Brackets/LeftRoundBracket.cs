namespace NutaParser.Lexical.Grammar
{
	public class LeftRoundBracket : SingleCharacterTerminal
	{
		public static readonly LeftRoundBracket S = new LeftRoundBracket();

		public LeftRoundBracket()
			: base('(')
		{
		}
	}
}
