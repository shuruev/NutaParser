namespace NutaParser.Lexical.Grammar
{
	public class InputElement : LexicalItem
	{
		public static readonly InputElement S = new InputElement();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				Whitespace.S,
				Comment.S,
				Token.S);
		}
	}
}
