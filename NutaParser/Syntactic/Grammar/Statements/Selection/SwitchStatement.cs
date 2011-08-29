namespace NutaParser.Syntactic.Grammar
{
	public class SwitchStatement : ParseAll
	{
		public static readonly SwitchStatement S = new SwitchStatement();

		public SwitchStatement()
			: base(
				SwitchTerminal.S,
				LeftRoundBracketTerminal.S,
				Expression.S,
				RightRoundBracketTerminal.S,
				SwitchBlock.S)
		{
		}
	}
}
