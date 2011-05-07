namespace NutaParser.Lexical.Grammar
{
	public class SingleLineComment : LexicalItem
	{
		public static readonly SingleLineComment S = new SingleLineComment();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				SingleLineComment1.S,
				SingleLineComment2.S);
		}
	}
}
