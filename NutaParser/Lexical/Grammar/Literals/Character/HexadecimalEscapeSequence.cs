namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalEscapeSequence : LexicalItem
	{
		public static readonly HexadecimalEscapeSequence S = new HexadecimalEscapeSequence();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				HexadecimalEscapeSequence1.S,
				HexadecimalEscapeSequence2.S,
				HexadecimalEscapeSequence3.S,
				HexadecimalEscapeSequence4.S);
		}
	}
}
