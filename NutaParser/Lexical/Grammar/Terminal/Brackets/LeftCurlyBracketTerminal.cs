namespace NutaParser.Lexical.Grammar
{
	public class LeftCurlyBracketTerminal : SingleCharacterTerminal
	{
		public static readonly LeftCurlyBracketTerminal S = new LeftCurlyBracketTerminal();

		public LeftCurlyBracketTerminal()
			: base('{')
		{
		}
	}
}
