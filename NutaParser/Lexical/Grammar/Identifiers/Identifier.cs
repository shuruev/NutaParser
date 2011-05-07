namespace NutaParser.Lexical.Grammar
{
	public class Identifier : LexicalItem
	{
		public static readonly Identifier S = new Identifier();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				Identifier1.S,
				AvailableIdentifier.S);
		}
	}
}
