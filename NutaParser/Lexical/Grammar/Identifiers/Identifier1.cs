namespace NutaParser.Lexical.Grammar
{
	public class Identifier1 : LexicalItem
	{
		public static readonly Identifier1 S = new Identifier1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				AtSignTerminal.S,
				IdentifierOrKeyword.S);
		}
	}
}
