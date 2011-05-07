namespace NutaParser.Lexical.Grammar
{
	public class DelimitedComment : LexicalItem
	{
		public static readonly DelimitedComment S = new DelimitedComment();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				DelimitedComment1.S,
				DelimitedComment2.S);
		}
	}
}
