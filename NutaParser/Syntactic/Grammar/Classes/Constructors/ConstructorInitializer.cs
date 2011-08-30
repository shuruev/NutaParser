namespace NutaParser.Syntactic.Grammar
{
	public class ConstructorInitializer : ParseAll
	{
		public static readonly ConstructorInitializer S = new ConstructorInitializer();
		public static readonly Optional O = new Optional(S);

		public ConstructorInitializer()
			: base(
				ColonTerminal.S,
				new ParseAny(BaseTerminal.S, ThisTerminal.S),
				LeftRoundBracketTerminal.S,
				ArgumentList.O,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
