namespace NutaParser.Syntactic.Grammar
{
	public class RightCurlyBracketTerminal : TextTerminal
	{
		public static readonly RightCurlyBracketTerminal S = new RightCurlyBracketTerminal();

		public RightCurlyBracketTerminal()
			: base("}")
		{
		}
	}
}
