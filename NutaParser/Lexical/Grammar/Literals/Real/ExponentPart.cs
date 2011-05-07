namespace NutaParser.Lexical.Grammar
{
	public class ExponentPart : LexicalItem
	{
		public static readonly ExponentPart S = new ExponentPart();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				ExponentPart1.S,
				ExponentPart2.S);
		}
	}
}
