namespace NutaParser.Syntactic.Grammar
{
	public class AttributeArguments : ParseAny
	{
		public static readonly AttributeArguments S = new AttributeArguments();
		public static readonly Optional O = new Optional(S);

		public AttributeArguments()
			: base(
				new ParseAll(
					LeftRoundBracketTerminal.S,
					PositionalArgumentList.O,
					RightRoundBracketTerminal.S),
				new ParseAll(
					LeftRoundBracketTerminal.S,
					PositionalArgumentList.S,
					CommaTerminal.S,
					NamedArgumentList.S,
					RightRoundBracketTerminal.S),
				new ParseAll(
					LeftRoundBracketTerminal.S,
					NamedArgumentList.S,
					RightRoundBracketTerminal.S))
		{
		}
	}
}
