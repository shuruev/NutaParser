namespace NutaParser.Syntactic.Grammar
{
	public class BaseAccess : ParseAny
	{
		public static readonly BaseAccess S = new BaseAccess();

		public BaseAccess()
			: base(
				new ParseAll(BaseTerminal.S, PeriodTerminal.S, IdentifierTerminal.S),
				new ParseAll(BaseTerminal.S, LeftSquareBracketTerminal.S, ArgumentList.S, RightSquareBracketTerminal.S))
		{
		}
	}
}
