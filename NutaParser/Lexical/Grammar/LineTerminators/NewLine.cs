namespace NutaParser.Lexical.Grammar
{
	public class NewLine : LexicalItem
	{
		public static readonly NewLine S = new NewLine();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(
				state,
				"\x000D\x000A",
				"\x000D",
				"\x000A",
				"\x0085",
				"\x2028",
				"\x2029");
		}
	}
}
