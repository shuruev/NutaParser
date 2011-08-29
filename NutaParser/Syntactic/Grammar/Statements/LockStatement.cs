namespace NutaParser.Syntactic.Grammar
{
	public class LockStatement : ParseAll
	{
		public static readonly LockStatement S = new LockStatement();

		public LockStatement()
			: base(
				LockTerminal.S,
				LeftRoundBracketTerminal.S,
				Expression.S,
				RightRoundBracketTerminal.S,
				EmbeddedStatement.S)
		{
		}
	}
}
