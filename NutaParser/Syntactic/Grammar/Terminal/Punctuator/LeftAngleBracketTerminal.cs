namespace NutaParser.Syntactic.Grammar
{
	public class LeftAngleBracketTerminal : TextTerminal
	{
		public static readonly LeftAngleBracketTerminal S = new LeftAngleBracketTerminal();

		public LeftAngleBracketTerminal()
			: base("<")
		{
		}
	}
}
