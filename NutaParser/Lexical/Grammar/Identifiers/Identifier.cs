namespace NutaParser.Lexical.Grammar
{
	public class Identifier : ParseAny
	{
		public static readonly Identifier S = new Identifier();

		public Identifier()
			: base(
				new ParseAll(AtSignTerminal.S, IdentifierOrKeyword.S),
				AvailableIdentifier.S)
		{
		}
	}
}
