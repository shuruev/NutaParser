namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection : LexicalItem
	{
		public static readonly PpElseSection S = new PpElseSection();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpElseSection1.S,
				PpElseSection2.S,
				PpElseSection3.S,
				PpElseSection4.S,
				PpElseSection5.S,
				PpElseSection6.S,
				PpElseSection7.S,
				PpElseSection8.S);
		}
	}
}
