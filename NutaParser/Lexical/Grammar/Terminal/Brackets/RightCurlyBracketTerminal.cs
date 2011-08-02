namespace NutaParser.Lexical.Grammar
{
	public class RightCurlyBracketTerminal : SingleCharacterTerminal
	{
		public static readonly RightCurlyBracketTerminal S = new RightCurlyBracketTerminal();

		public RightCurlyBracketTerminal()
			: base('}')
		{
		}
	}
}
